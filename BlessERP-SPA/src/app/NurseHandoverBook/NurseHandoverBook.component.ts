import { Component, OnInit } from '@angular/core';
import { NurseHandoverBook } from '../Model/NurseHandoverBook';
import { NurseHandoverBookService } from '../_services/nurseHandoverBook.service';

@Component({
  selector: "app-NurseHandoverBook",
  templateUrl: './NurseHandoverBook.component.html',
  styleUrls: ['./NurseHandoverBook.component.css']
})
export class NurseHandoverBookComponent implements OnInit {
  nurseHandOverBookList: NurseHandoverBook[];
  newNurseHandoverBook: NurseHandoverBook = new NurseHandoverBook();

  constructor(private nurseHandoverBookService: NurseHandoverBookService) {}

  ngOnInit() {
    this.nurseHandoverBookService
      .getNurseHandoverBook()
      .subscribe((response: NurseHandoverBook[]) => {
        this.nurseHandOverBookList = response;
      });
  }
  onSaveClick() {
    this.nurseHandoverBookService
      .postNurseHandoverBook(this.newNurseHandoverBook)
      .subscribe(
        response => {
          this.nurseHandOverBookList.push(this.newNurseHandoverBook);
        },
        error => {
          console.log(error);
        }
      );
  }
}
