import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {RecipientsService} from "../shared/recipients.service";
import {HttpErrorResponse} from "@angular/common/http";
import {throwError} from "rxjs";
import {catchError} from "rxjs/operators";

@Component({
  selector: 'app-recipient-create-dialog',
  templateUrl: './recipient-create-dialog.component.html',
  styleUrls: ['./recipient-create-dialog.component.scss']
})
export class RecipientCreateDialogComponent implements OnInit {
  recipientForm: FormGroup;
  submitted = false;

  constructor(private formBuilder: FormBuilder,
              private recipientsService: RecipientsService) { }

  ngOnInit() {
    this.createRecipientForm();
  }

  onSubmit() {
    this.submitted = true;

    if (this.recipientForm.invalid) {
      return;
    }

    return this.recipientsService.createRecipient(this.recipientForm.value)
      .pipe(
        catchError(this.handleError)
      ).subscribe(
        response => console.log(response),
        err => console.log(err)
      );
  }

  private createRecipientForm(){
    this.recipientForm = this.formBuilder.group({
      name: ['', Validators.required],
      city: ['', Validators.required],
      street: ['', Validators.required],
      number: ['', Validators.required],
    });
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
