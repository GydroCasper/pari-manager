import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pari-bettors-edit',
  templateUrl: './pari-bettors-edit.component.html',
  styleUrls: ['./pari-bettors-edit.component.css']
})
export class PariBettorsEditComponent implements OnInit {
  @Input() bettors: string[];

  addBettor() {
    if(!this.bettors) this.bettors = [];
    this.bettors.push('');
  }

  constructor() { }

  ngOnInit() {
  }

}
