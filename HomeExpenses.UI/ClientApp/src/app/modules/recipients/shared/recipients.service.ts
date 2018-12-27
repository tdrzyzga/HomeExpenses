import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";

import {Recipient} from "./dto/Recipient";

@Injectable({
  providedIn: 'root'
})

export class RecipientsService {

  private path = 'http://localhost:60440/api/Recipients/F16CE11C-CA45-4449-A942-54F4B22106EA';

  constructor(private http: HttpClient) { }

  getRecipients () {
    return this.http.get<Recipient>(this.path);
  }
}
