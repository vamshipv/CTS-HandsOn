import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})

export class UserService {
  id: number;
  email: string;
  first_name: string;
  last_name: string;

  result: string;


  constructor(private http: HttpClient) {
    this.id = 0;
    this.email = "";
    this.first_name = "";
    this.last_name = "";

    this.result = "";
   }

  getAlUser(): Observable<any> {
    const url = "https://reqres.in/api/users?page=2";
    return this.http.get<any>(url);
  }

  post(id: number, email: string, first_name: string, last_name: string) {
    const url = "https://reqres.in/api/users";
    this.http.post(url, {
        id: this.id,
        email: this.email,
        first_name: this.first_name,
        last_name: this.last_name
    }).toPromise().then((data: any) =>{
      this.result = JSON.stringify(data.json);
    })
  }
}
