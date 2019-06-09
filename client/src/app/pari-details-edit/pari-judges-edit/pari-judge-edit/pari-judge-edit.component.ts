import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pari-judge-edit',
  templateUrl: './pari-judge-edit.component.html',
  styleUrls: ['./pari-judge-edit.component.css']
})
export class PariJudgeEditComponent implements OnInit {
  @Input() judge: string;
  
  constructor() { }

  ngOnInit() {
  }

}
