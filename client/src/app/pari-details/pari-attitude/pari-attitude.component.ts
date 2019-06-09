import { Component, OnInit, Input } from '@angular/core';
import { Attitude } from 'src/app/shared/attitude';

@Component({
  selector: 'app-pari-attitude',
  templateUrl: './pari-attitude.component.html',
  styleUrls: ['./pari-attitude.component.css']
})
export class PariAttitudeComponent implements OnInit {
  @Input() attitude: Attitude;

  constructor() { }

  ngOnInit() {
  }
}
