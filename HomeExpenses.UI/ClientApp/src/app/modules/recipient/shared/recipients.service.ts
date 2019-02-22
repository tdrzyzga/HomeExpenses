import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";

import {Recipient} from "./dto/Recipient";
import {CreateRecipient} from "./dto/CreateRecipient";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})

export class RecipientsService {

  private path = 'http://localhost:60440/api/recipients';

  constructor(private http: HttpClient) { }

  getRecipients (): Observable<Recipient> {
    return this.http.get<Recipient>(`${this.path}/44F328C8-40CC-4735-A3FA-84E9092223D3`);
  }

  createRecipient(recipientData: CreateRecipient) {
    return this.http.post(this.path, recipientData);
  }
}
