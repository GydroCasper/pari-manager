import { BrowserModule } from '@angular/platform-browser';
import { NgModule  } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PariListComponent } from './pari-list/pari-list.component';
import { PariDetailsComponent } from './pari-details/pari-details.component';
import { PariItemComponent } from './pari-item/pari-item.component';
import { Routes, RouterModule } from '@angular/router';
import { PariDetailsEditComponent } from './pari-details-edit/pari-details-edit.component';
import { PariJudgesComponent } from './pari-details/pari-judges/pari-judges.component';
import { PariAttitudeComponent } from './pari-details/pari-attitude/pari-attitude.component';

const appRoutes: Routes = [
  { path: '', component: PariListComponent},
  { path: 'pari/:id/edit', component: PariDetailsEditComponent},
  { path: 'pari/edit', component: PariDetailsEditComponent},
  { path: 'pari/:id', component: PariDetailsComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    PariListComponent,
    PariDetailsComponent,
    PariItemComponent,
    PariDetailsEditComponent,
    PariJudgesComponent,
    PariAttitudeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
