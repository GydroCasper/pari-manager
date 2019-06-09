import { Injectable } from '@angular/core';

@Injectable()
export class httpConstsService {
    baseUrl = "https://szhgrx2wr3.execute-api.us-east-1.amazonaws.com/prod";


    public getPariListUrl = this.baseUrl;
    public getPariDetailsUrl = this.baseUrl;
}