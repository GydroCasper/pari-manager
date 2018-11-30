import { Pari} from '../shared/pari';
import { Injectable } from '@angular/core';

@Injectable()
export class PariListService{
    pariList: Pari[];
    getPariList();

    getPariList() : Pari[]{
        this.pariList = [
            {name: "Выебать Лёху на тему Курил", id: 'a532852b-cab6-4db8-94c7-db447ff65c8e'}, 
            {name: "Поиметь Бобруцкова на тему Кокорина и Мамаева", id: '086d2f11-775c-425d-9bb4-c2ce107c0cc7'}
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