import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { User} from '../user';
import { Company } from '../company';
import { StockExchanges } from '../stock-exchanges';
import { IPOdetails } from '../ipodetails';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  username:string;
  usertype:string;
  constructor(private http : HttpClient) { }

    public Getallusers():Observable<User[]>
    {
      return this.http.get<User[]>("http://localhost:56497/api/User/getall");
    }
    public userLogin(user:User)
    {
      return this.http.post("http://localhost:56497/api/User/check",user,{ responseType: 'text' });
    }

    public adminLogin(user:User)
    {
      return this.http.post("http://localhost:56497/api/Admin/check",user,{ responseType: 'text' });
    }

    public signup(user:User)
    {
      return this.http.post("http://localhost:56497/api/User/add",user,{ responseType: 'text' });
    }
    public addcompany(company:Company)
    {
      return this.http.post("http://localhost:52843/api/Company/addcompany",company,{ responseType: 'text' });
    }
    public updatecompany(company:Company)
    {
      return this.http.put("http://localhost:52843/api/Company/updatecompany",company,{ responseType: 'text' });
    }
    public addstockexchange(stockexchange: StockExchanges)
    {
      return this.http.post("http://localhost:62478/api/StockExchange/add",stockexchange,{ responseType: 'text' });
    }
    public getallse()
    {
      return this.http.get("http://localhost:62478/api/StockExchange/getall");
    }
    public addIPO(ipo:IPOdetails)
    {
      return this.http.post("http://localhost:52843/api/Company/addIPO",ipo,{responseType:'text'});
    }
    public getallIPO()
    {
      return this.http.get("http://localhost:52843/api/Company/getallIPO");
    }
    public getstockpricelist(code:number,fromdate:Date,todate:Date,fromtime:string,totime:string):Observable<number[]>
    {
      return this.http.get<number[]>("http://localhost:52843/api/Company/getchart/"+code+"/"+fromdate+"/"+todate+"/"+fromtime+"/"+totime);
    }
    public getsectorpricelist(code:string,fromdate:Date,todate:Date,fromtime:string,totime:string):Observable<number[]>
    {
      return this.http.get<number[]>("http://localhost:49953/api/Sector/sectorpricelist/"+code+"/"+fromdate+"/"+todate+"/"+fromtime+"/"+totime);
    }
}