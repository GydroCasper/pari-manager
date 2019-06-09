import { Component, OnInit, Input } from '@angular/core';
import { Attitude } from 'src/app/shared/attitude';

@Component({
  selector: 'app-pari-attitude-edit',
  templateUrl: './pari-attitude-edit.component.html',
  styleUrls: ['./pari-attitude-edit.component.css']
})
export class PariAttitudeEditComponent implements OnInit {
  @Input() attitude: Attitude; 

  constructor() { }

  ngOnInit() {
  }

}
