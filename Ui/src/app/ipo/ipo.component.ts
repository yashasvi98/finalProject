import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
import { IPOdetails} from '../ipodetails';
@Component({
  selector: 'app-ipo',
  templateUrl: './ipo.component.html',
  styleUrls: ['./ipo.component.css']
})
export class IPOComponent implements OnInit {
  Id: number;
  CompanyName: string;
  StockExchange: string;
  PricePerShare: number;
  TotalNoOfShares: number;
  OpenDateTime: Date;
  Remarks: string
ipo:IPOdetails;
  constructor(private service : ProductService, private router:Router) { }

  ngOnInit(): void {
    this.ipo = new IPOdetails;
  }

  addIPO()
  {
    this.ipo.id = this.Id;
    this.ipo.companyName = this.CompanyName;
    this.ipo.openDateTime = this.OpenDateTime;
    this.ipo.pricePerShare = this.PricePerShare;
    this.ipo.remarks = this.Remarks;
    this.ipo.stockExchange = this.StockExchange;
    this.ipo.totalNoOfShares = this.TotalNoOfShares;
    console.log(this.ipo);

  this.service.addIPO(this.ipo).subscribe(i=>{
    console.log(i.toString());});
  }
  
}
