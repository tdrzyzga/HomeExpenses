import { Component, OnInit } from '@angular/core';
import {RecipientsService} from "./recipients.service";
import {IRecipient} from "./dto/IRecipient";

@Component({
  selector: 'app-recipients',
  templateUrl: './recipients.component.html',
  styleUrls: ['./recipients.component.css']
})
export class RecipientsComponent implements OnInit {
  recipient: IRecipient ;

  constructor(private recipientsService: RecipientsService) { }

  ngOnInit() {
    this.recipientsService.getRecipients()
      .subscribe(recipient => this.recipient = recipient);
  }
}
