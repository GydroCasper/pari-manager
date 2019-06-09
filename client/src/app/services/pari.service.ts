import { Pari} from '../shared/pari';
import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { httpConstsService } from '../shared/const/httpConstsService';
import { Command } from '../shared/command';

@Injectable()
export class PariService implements OnInit{
    constructor(private http: HttpClient, private httpConstsService: httpConstsService) {
    }

    ngOnInit() {
    }

    getPariList(): Observable<Pari[]>{
        return this.http.get<Pari[]>(this.httpConstsService.getPariListUrl); 
    }

    getPariDetails(id: number): Observable<Pari>{
        return this.http.get<Pari>(this.httpConstsService.getPariDetailsUrl + "/" + id);
    }

    createPari(pari: Pari): Observable<string> {
        let command : Command<Pari> = { name: 'CreatePari', body: pari};
        return this.http.put<string>(this.httpConstsService.getPariListUrl, command);
    }
}