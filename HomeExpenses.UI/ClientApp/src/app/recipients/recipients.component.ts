import { Component, OnInit } from '@angular/core';
import {RecipientsService} from "./recipients.service";
import { Recipient} from "./dto/Recipient";
import {HttpErrorResponse} from "@angular/common/http";
import {throwError} from "rxjs";
import {catchError} from "rxjs/operators";

@Component({
  selector: 'app-recipients',
  templateUrl: './recipients.component.html',
  styleUrls: ['./recipients.component.css']
})
export class RecipientsComponent implements OnInit {
  recipient: Recipient ;

  constructor(private recipientsService: RecipientsService) { }

  ngOnInit() {
    this.recipientsService.getRecipients()
      .pipe(
        catchError(this.handleError)
      )
      .subscribe(recipient => this.recipient = recipient);
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // return an observable with a user-facing error message
    return throwError(
      'Something bad happened; please try again later.' + error.error.status);
  };
}
