import { Component } from '@angular/core';
import { PariService } from './services/pari.service';
import { httpConstsService } from './shared/const/httpConstsService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [
    PariService,
    httpConstsService
  ]
})
export class AppComponent {
  title = 'pari-manager';
}
