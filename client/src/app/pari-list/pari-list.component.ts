import { Component, OnInit, OnDestroy } from '@angular/core';
import { PariService } from '../services/pari.service';
import { Pari } from '../shared/pari';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-pari-list',
  templateUrl: './pari-list.component.html',
  styleUrls: ['./pari-list.component.css']
})
export class PariListComponent implements OnInit, OnDestroy {
  pariList: Pari[];
  pariListSubscription: Subscription;

  constructor(private pariService: PariService) {
   }

  ngOnInit() {
    this.pariListSubscription = this.pariService.getPariList()
      .subscribe(
        (params: Pari[]) => {
          this.pariList = params;
        }
      );
  }

  ngOnDestroy(): void {
    this.pariListSubscription.unsubscribe();
  }
}
  