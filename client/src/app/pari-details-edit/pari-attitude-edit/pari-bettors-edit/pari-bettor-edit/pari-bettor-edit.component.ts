import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pari-bettor-edit',
  templateUrl: './pari-bettor-edit.component.html',
  styleUrls: ['./pari-bettor-edit.component.css']
})
export class PariBettorEditComponent implements OnInit {
  @Input() bettor: string;
  
  constructor() { }

  ngOnInit() {
  }

}
