import { Injectable } from '@angular/core';

@Injectable()
export class httpConstsService {
    private basicUrl: string = "https://ctd84g68jc.execute-api.us-east-1.amazonaws.com/prod";

    public getPariListUrl = this.basicUrl + "/pari";
}