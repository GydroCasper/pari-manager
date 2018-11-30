import { Component, OnInit } from '@angular/core';
import { PariListService } from '../services/pari-list.service';
import { Pari } from '../shared/pari';

@Component({
  selector: 'app-pari-list',
  templateUrl: './pari-list.component.html',
  styleUrls: ['./pari-list.component.css']
})
export class PariListComponent implements OnInit {
  pariList: Pari[];

  constructor(private pariService: PariListService) {
    this.pariList = this.pariService.getPariList();
   }

  ngOnInit() {
  }
}
  