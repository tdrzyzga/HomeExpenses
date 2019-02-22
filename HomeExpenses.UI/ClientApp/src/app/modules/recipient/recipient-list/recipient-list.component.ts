import { Component, OnInit } from '@angular/core';
import {HttpErrorResponse} from "@angular/common/http";
import {throwError} from "rxjs";
import {catchError} from "rxjs/operators";


import { Recipient} from "../shared/dto/Recipient";
import {RecipientsService} from "../shared/recipients.service";
import {MatDialog, MatDialogConfig} from "@angular/material";
import {RecipientCreateDialogComponent} from "../recipient-create-dialog/recipient-create-dialog.component";

@Component({
  selector: 'recipient-list',
  templateUrl: './recipient-list.component.html',
  styleUrls: ['./recipient-list.component.scss']
})
export class RecipientListComponent implements OnInit {
  recipient: Recipient ;

  constructor(private recipientsService: RecipientsService,
              private createRecipientDialog: MatDialog) { }

  ngOnInit() {
    this.recipientsService.getRecipients()
      .pipe(
        catchError(this.handleError)
      )
      .subscribe(recipient => this.recipient = recipient);
  }

  createRecipient() {

    const dialogConfig = new MatDialogConfig();

    dialogConfig.disableClose = false;
    dialogConfig.autoFocus = true;

    this.createRecipientDialog.open(RecipientCreateDialogComponent, dialogConfig);
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
