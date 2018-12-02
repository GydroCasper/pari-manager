import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pari-judges',
  templateUrl: './pari-judges.component.html',
  styleUrls: ['./pari-judges.component.css']
})
export class PariJudgesComponent implements OnInit {
  @Input() judges: string[];

  constructor() { }

  ngOnInit() {
  }
}
