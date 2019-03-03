import {Component, OnInit, ViewChild} from '@angular/core';
import {HttpErrorResponse} from "@angular/common/http";
import {throwError} from "rxjs";
import {catchError} from "rxjs/operators";


import { Recipient} from "../shared/dto/Recipient";
import {RecipientsService} from "../shared/recipients.service";
import {MatDialog, MatDialogConfig, MatPaginator, MatTableDataSource, PageEvent} from "@angular/material";
import {RecipientCreateDialogComponent} from "../recipient-create-dialog/recipient-create-dialog.component";

@Component({
  selector: 'recipient-list',
  templateUrl: './recipient-list.component.html',
  styleUrls: ['./recipient-list.component.scss']
})
export class RecipientListComponent implements OnInit {
  displayedColumns: string[] = ['name', 'city', 'street', 'number'];
  recipientList: MatTableDataSource<Recipient>;
  pageIndex: number;
  itemsPerPage: number;
  sortBy: string;
  sortDir: string;
  totalItems: number;
  pageSizeOptions: number[] = [2, 5, 10];

  constructor(private recipientsService: RecipientsService,
              private createRecipientDialog: MatDialog) { }

  ngOnInit() {
    this.pageIndex = 1;
    this.itemsPerPage = 2;
    this.sortBy = 'name';
    this.sortDir = "Asc";

    this.getRecipients();
  }

  pageEvent($event: PageEvent): void {
    this.pageIndex = $event.pageIndex + 1;
    this.itemsPerPage = $event.pageSize;

    return this.getRecipients();
  }

  createRecipient() {

    const dialogConfig = new MatDialogConfig();

    dialogConfig.disableClose = false;
    dialogConfig.autoFocus = true;

    this.createRecipientDialog.open(RecipientCreateDialogComponent, dialogConfig);

    this.getRecipients();
  }

  private getRecipients(){
    this.recipientsService.getRecipients(this.pageIndex, this.itemsPerPage, this.sortBy, this.sortDir)
      .pipe(
        catchError(this.handleError)
      )
      .subscribe(recipientList => {
        this.recipientList = new MatTableDataSource<Recipient>(recipientList.items);
        this.totalItems = recipientList.totalItems;
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
