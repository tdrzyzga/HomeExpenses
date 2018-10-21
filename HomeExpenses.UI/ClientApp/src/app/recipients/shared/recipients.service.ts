import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";

import {Recipient} from "./dto/Recipient";

@Injectable({
  providedIn: 'root'
})

export class RecipientsService {

  private path = 'http://localhost:60440/api/Recipients/05B25BE9-FA01-409C-A8EF-82806C3000A0';

  constructor(private http: HttpClient) { }

  getRecipients () {
    return this.http.get<Recipient>(this.path);
  }
}
