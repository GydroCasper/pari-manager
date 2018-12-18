import { Pari} from '../shared/pari';
import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class PariListService implements OnInit{
    pariList: Pari[];

    constructor(private http: HttpClient) {
    }

    ngOnInit() {
        this.pariList = this.getPariList();
    }

    async getPariList() : Pari[]{
        return await this.http.get<Pari[]>("https://ctd84g68jc.execute-api.us-east-1.amazonaws.com/prod/pari").toPromise();
        // var s = this.http.get<Pari[]>("https://ctd84g68jc.execute-api.us-east-1.amazonaws.com/prod/pari").subscribe(value => {
        //     this.pariList = value;
        //     return this.pariList.slice();
        // }, error => { 
        //     console.log(error);
        //     return null;
        // });
    }

    getPariById(id: string): Pari {
        for(var i=0;i<this.pariList.length;i++){
            var el = this.pariList[i];
            if(el.id === id) return el;
        }
    }
}