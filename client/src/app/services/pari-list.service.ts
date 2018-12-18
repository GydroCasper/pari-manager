import { Pari} from '../shared/pari';
import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { httpConstsService } from '../shared/const/httpConstsService';

@Injectable()
export class PariListService implements OnInit{
    constructor(private http: HttpClient, private httpConstsService: httpConstsService) {
    }

    ngOnInit() {
    }

    getPariList(): Observable<Pari[]>{
        return this.http.get<Pari[]>(this.httpConstsService.getPariListUrl); 
    }

    // getPariById(id: string): Pari {
    //     for(var i=0;i<this.pariList.length;i++){
    //         var el = this.pariList[i];
    //         if(el.id === id) return el;
    //     }
    // }
}