import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PariListComponent } from './pari-list/pari-list.component';
import { PariDetailsComponent } from './pari-details/pari-details.component';
import { PariItemComponent } from './pari-item/pari-item.component';
import { Routes, RouterModule } from '@angular/router';
import { PariListService } from './services/pari-list.service';

const appRoutes: Routes = [
  { path: '', component: PariListComponent},
  { path: 'pari/:id', component: PariDetailsComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    PariListComponent,
    PariDetailsComponent,
    PariItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
