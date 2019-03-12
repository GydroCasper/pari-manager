import { Component, OnInit } from '@angular/core';
import { Pari } from '../shared/pari';
import { Attitude } from '../shared/attitude';

@Component({
  selector: 'app-pari-details-edit',
  templateUrl: './pari-details-edit.component.html',
  styleUrls: ['./pari-details-edit.component.css']
})
export class PariDetailsEditComponent implements OnInit {
  pari: Pari = {
    id:  null,
    name: null,
    date: null,
    judges: null,
    attitudes: [
      new Attitude(),
      new Attitude
    ]
  };
  
  constructor() {
   }

  ngOnInit() {
  }

}
