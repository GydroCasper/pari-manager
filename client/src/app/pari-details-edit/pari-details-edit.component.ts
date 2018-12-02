import { Component, OnInit } from '@angular/core';
import { Pari } from '../shared/pari';

@Component({
  selector: 'app-pari-details-edit',
  templateUrl: './pari-details-edit.component.html',
  styleUrls: ['./pari-details-edit.component.css']
})
export class PariDetailsEditComponent implements OnInit {
  pari: Pari = new Pari();

  constructor() { }

  ngOnInit() {
  }

}
