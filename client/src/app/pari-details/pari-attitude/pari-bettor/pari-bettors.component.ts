import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pari-bettors',
  templateUrl: './pari-bettors.component.html',
  styleUrls: ['./pari-bettors.component.css']
})
export class PariBettorsComponent implements OnInit {
  @Input() bettors: string[];

  constructor() { }

  ngOnInit() {
  }
}