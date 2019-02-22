import { Injectable } from '@angular/core';

@Injectable()
export class httpConstsService {
    public getPariListUrl = "https://9f75bcptu9.execute-api.us-east-1.amazonaws.com/prod/pariMan-get-list";
    public getPariDetailsUrl = "https://szhgrx2wr3.execute-api.us-east-1.amazonaws.com/prod";
}