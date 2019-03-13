import { Component, OnInit, OnDestroy } from '@angular/core';
import { Pari } from '../shared/pari';
import { Attitude } from '../shared/attitude';
import { PariService } from '../services/pari.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-pari-details-edit',
  templateUrl: './pari-details-edit.component.html',
  styleUrls: ['./pari-details-edit.component.css']
})
export class PariDetailsEditComponent implements OnInit, OnDestroy {
  pari: Pari = {
    id: null,
    name: null,
    date: new Date(),
    judges: null,
    attitudes: [
      new Attitude(),
      new Attitude
    ]
  };

  pariSubscription: Subscription;

  save() {
    this.pariSubscription = this.pariService.createPari(this.pari)
      .subscribe(
        (params: string) => {
          this.pari.id = params;
        }
      );
  }

  constructor(private pariService: PariService) {
  }

  ngOnInit() {
  }

  ngOnDestroy(): void {
    this.pariSubscription.unsubscribe();
  }
}
