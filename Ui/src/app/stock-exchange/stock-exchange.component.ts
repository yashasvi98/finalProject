import { Component, OnInit } from '@angular/core';
import {StockExchanges} from '../stock-exchanges';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-stock-exchange',
  templateUrl: './stock-exchange.component.html',
  styleUrls: ['./stock-exchange.component.css']
})
export class StockExchangeComponent implements OnInit {
  seid : number ;
  stockExchange  : string;
  brief : string;
  address : string;
  remarks : string;
  se : StockExchanges;
  list:any;
  constructor(private service : ProductService, private router:Router) { 
    this.se = new StockExchanges;
  }

  ngOnInit(): void {
  }
addstockexchange()
{
  this.se.Address = this.address;
  this.se.Brief = this.brief;
  this.se.Remarks = this.remarks;
  this.se.Seid = this.seid;
  this.se.StockExchange = this.stockExchange;

  console.log(this.se);

    this.service.addstockexchange(this.se).subscribe(i=>{
      console.log(i.toString());});
}
getallse()
{
  
    this.service.getallse().subscribe(i=>{
      this.list = i;
      console.log(this.list);
    });
}
}
