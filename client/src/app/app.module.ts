import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDatepickerModule, MatNativeDateModule, MatButtonModule, MatFormFieldModule, MatInputModule, MatRippleModule } from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PariListComponent } from './pari-list/pari-list.component';
import { PariDetailsComponent } from './pari-details/pari-details.component';
import { PariItemComponent } from './pari-item/pari-item.component';
import { Routes, RouterModule } from '@angular/router';
import { PariDetailsEditComponent } from './pari-details-edit/pari-details-edit.component';
import { PariJudgesComponent } from './pari-details/pari-judges/pari-judges.component';
import { PariAttitudeComponent } from './pari-details/pari-attitude/pari-attitude.component';
import { PariBettorsComponent } from './pari-details/pari-attitude/pari-bettor/pari-bettors.component';
import { ResponseInterceptor } from './interceptors/response-interceptor';
import { PariAttitudeEditComponent } from './pari-details-edit/pari-attitude-edit/pari-attitude-edit.component';
import { PariJudgesEditComponent } from './pari-details-edit/pari-judges-edit/pari-judges-edit.component';
import { PariBettorsEditComponent } from './pari-details-edit/pari-attitude-edit/pari-bettors-edit/pari-bettors-edit.component';
import { PariBettorEditComponent } from './pari-details-edit/pari-attitude-edit/pari-bettors-edit/pari-bettor-edit/pari-bettor-edit.component';
import { PariJudgeEditComponent } from './pari-details-edit/pari-judges-edit/pari-judge-edit/pari-judge-edit.component';

const appRoutes: Routes = [
  { path: '', component: PariListComponent },
  { path: 'pari/:id/edit', component: PariDetailsEditComponent },
  { path: 'pari/edit', component: PariDetailsEditComponent },
  { path: 'pari/:id', component: PariDetailsComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    PariListComponent,
    PariDetailsComponent,
    PariItemComponent,
    PariDetailsEditComponent,
    PariJudgesComponent,
    PariAttitudeComponent,
    PariBettorsComponent,
    PariAttitudeEditComponent,
    PariJudgesEditComponent,
    PariBettorsEditComponent,
    PariBettorEditComponent,
    PariJudgeEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatFormFieldModule,
    MatButtonModule,
    MatInputModule,
    MatRippleModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ResponseInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent],
  exports: [MatDatepickerModule, MatButtonModule, MatFormFieldModule, MatInputModule, MatRippleModule]
})
export class AppModule { }
