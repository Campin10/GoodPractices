import { Component, Inject } from '@angular/core';
import { HttpClient, HttpBackend,HttpParams } from '@angular/common/http';
@Component({
  selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
    export class HomeComponent {
    public employe ={idEmploye: ""}; 
    public employess: EmployessInfo[];
     
  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {  
  }

    public getEmployess() {
      var params = new  HttpParams().set('idEmploye', this.employe.idEmploye);
      this.http.get<EmployessInfo[]>(this.baseUrl + 'api/EmployessContract/GetEmployess',{params}).subscribe(result => {
      this.employess = result;
    }, error => console.error(error));
  }

}

interface EmployessInfo {
    id: number;
    name: string;
    contractTypeName: string;
    roleName: string;
    roleDescription: string;
    salary: number;
    annualSalary: number;
}

