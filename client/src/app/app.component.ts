import { Component } from '@angular/core';
import { PariListService } from './services/pari-list.service';
import { httpConstsService } from './shared/const/httpConstsService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [
    PariListService,
    httpConstsService
  ]
})
export class AppComponent {
  title = 'pari-manager';
}
