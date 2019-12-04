import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";

import {Recipient, RecipientList} from "./dto/Recipient";
import {CreateRecipient} from "./dto/CreateRecipient";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})

export class RecipientsService {

  private path = 'http://localhost:60440/api/recipients';

  constructor(private http: HttpClient) { }

  getRecipients (pageIndex: number, itemsPerPage: number, sortBy: string, sortDir: string): Observable<RecipientList> {
    const params: any = {
      pageIndex: pageIndex,
      itemsPerPage: itemsPerPage,
      sortBy: sortBy,
      sortDir: sortDir
    };

    return this.http.get<RecipientList>(this.path, { params: params });
  }

  createRecipient(recipientData: CreateRecipient) {
    return this.http.post(this.path, recipientData);
  }
}
