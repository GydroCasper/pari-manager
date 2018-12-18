import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PariListService } from '../services/pari-list.service';

@Component({
  selector: 'app-pari-details',
  templateUrl: './pari-details.component.html',
  styleUrls: ['./pari-details.component.css']
})
export class PariDetailsComponent implements OnInit {
  // pari: Pari = this.pariListService.getPariById(this.route.snapshot.params['id']);

  constructor(private route: ActivatedRoute, private pariListService: PariListService) { }

  ngOnInit() {
  }
}
