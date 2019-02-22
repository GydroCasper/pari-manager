import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PariService } from '../services/pari.service';
import { Pari } from '../shared/pari';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-pari-details',
  templateUrl: './pari-details.component.html',
  styleUrls: ['./pari-details.component.css']
})
export class PariDetailsComponent implements OnInit, OnDestroy {
  pariSubscription: Subscription;
  pari: Pari = {id : '', name: '', date: new Date(), judges: [], attitudes: []};

  constructor(private route: ActivatedRoute, private pariService: PariService) { }

  ngOnInit() {
    this.pariSubscription = this.pariService.getPariDetails(this.route.snapshot.params['id'])
      .subscribe(
        (params: Pari) => {
          this.pari = params;
        }
      );
  }
 
  ngOnDestroy(): void {
    this.pariSubscription.unsubscribe();
  }
}
