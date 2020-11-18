import { Component, OnInit } from '@angular/core';
import {Company } from '../company';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
  CompanyId : number;
  CompanyName : string;
  Turnover : number;
  CEO : string;
  BoardOfDirectors : string;
  ListedInStockExchange : number;
  Sector : string;
  BriefWriteup : string;
  CompanyStockCode : number;
  comp: Company;
  
  constructor(private service : ProductService, private router:Router) { 
    this.comp = new Company; 
  }

  ngOnInit(): void 
  {
  }

  addcompany()
  {
    this.comp.companyId = this.CompanyId;
    this.comp.companyName = this.CompanyName;
    this.comp.turnover = this.Turnover;
    this.comp.ceo = this.CEO;
    this.comp.sector = this.Sector;
    this.comp.boardOfDirectors = this.BoardOfDirectors;
    this.comp.briefWriteUp  = this.BriefWriteup;
    this.comp.companyStockCode = this.CompanyStockCode;
    this.comp.listedinStockExchange = this.ListedInStockExchange;

    console.log(this.comp);

    this.service.addcompany(this.comp).subscribe(i=>{
      console.log(i.toString());});
    
  }
  updatecompany()
  {
    this.comp.companyId = this.CompanyId;
    this.comp.companyName = this.CompanyName;
    this.comp.turnover = this.Turnover;
    this.comp.ceo = this.CEO;
    this.comp.sector = this.Sector;
    this.comp.boardOfDirectors = this.BoardOfDirectors;
    this.comp.briefWriteUp  = this.BriefWriteup;
    this.comp.companyStockCode = this.CompanyStockCode;
    this.comp.listedinStockExchange = this.ListedInStockExchange;

    console.log(this.comp);

    this.service.updatecompany(this.comp).subscribe(i=>{
      console.log(i.toString());});
    
  }
}
