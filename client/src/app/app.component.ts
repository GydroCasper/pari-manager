import { Component } from '@angular/core';
import { PariListService } from './services/pari-list.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [PariListService]
})
export class AppComponent {
  title = 'pari-manager';
}
