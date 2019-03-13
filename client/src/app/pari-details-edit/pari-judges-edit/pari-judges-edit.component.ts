import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pari-judges-edit',
  templateUrl: './pari-judges-edit.component.html',
  styleUrls: ['./pari-judges-edit.component.css']
})
export class PariJudgesEditComponent implements OnInit {
  @Input() judges: string[];

  addJudge() {
    if(!this.judges) this.judges = [];
    this.judges.push('');
  }

  constructor() { }

  ngOnInit() {
  }
}
