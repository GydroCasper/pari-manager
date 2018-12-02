import { Component, OnInit, Input } from '@angular/core';
import { Pari } from '../shared/pari';

@Component({
  selector: 'app-pari-item',
  templateUrl: './pari-item.component.html',
  styleUrls: ['./pari-item.component.css']
})
export class PariItemComponent implements OnInit {
  @Input() pari: Pari;

  constructor() { }

  ngOnInit() {
  }

}
