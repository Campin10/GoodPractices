import { HttpClient,HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import {EmployessInfo} from '../models/employees';
import { paramsService } from '../service/serviceParams'

@Injectable()
export class callService{
    constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {  
    }
    public getService(url?: string,params?: Object){
        var paramsHttp =  paramsService.getParams(params)
        return this.http.get<EmployessInfo[]>(`${this.baseUrl}${url}?${paramsHttp}`)
    }
}