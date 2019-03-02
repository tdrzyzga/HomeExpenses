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

  getRecipients (): Observable<RecipientList> {
    return this.http.get<RecipientList>(this.path);
  }

  createRecipient(recipientData: CreateRecipient) {
    return this.http.post(this.path, recipientData);
  }
}
