import { Pari} from '../shared/pari';
import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class PariListService implements OnInit{
    pariList: Pari[];

    constructor(private http: HttpClient) {
        
    }

    ngOnInit() {
        this.getPariList();
    }

    getPariList() : Pari[]{
        var s = this.http.get("https://ctd84g68jc.execute-api.us-east-1.amazonaws.com/prod/pari").subscribe(value => {
            console.log(value);
        }, error => { 
            console.log(error)
        });

        this.pariList = [
            {name: "Выебать Лёху на тему Курил", id: 'a532852b-cab6-4db8-94c7-db447ff65c8e', date: new Date(2019, 1, 1), judges: ['Вася', 'Петя'], attitudes: null}, 
            {name: "Поиметь Бобруцкова на тему Кокорина и Мамаева", id: '086d2f11-775c-425d-9bb4-c2ce107c0cc7', date: new Date(2018, 12, 5), judges: ['Пьерлуиджи Колина'], attitudes: null}
        ];

        return this.pariList.slice();
    }

    getPariById(id: string): Pari {
        for(var i=0;i<this.pariList.length;i++){
            var el = this.pariList[i];
            if(el.id === id) return el;
        }
    }
}