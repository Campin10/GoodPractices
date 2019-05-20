import { Component } from '@angular/core';
import { EmployessInfo } from '../models/employees';
import { callService } from '../service/service';

@Component({
  selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
    export class HomeComponent {
    public employe ={idEmploye: 0}; 
    public employess: EmployessInfo[];
    
    constructor(public callservice: callService) {  
    }
    public getEmployess() {
      this.callservice.getService('api/EmployessContract/GetEmployess',{'idEmploye': this.employe.idEmploye}).subscribe((res)=>{
        this.employess = res;      
      });
    }

}




