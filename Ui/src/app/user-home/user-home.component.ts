import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-home',
  templateUrl: './user-home.component.html',
  styleUrls: ['./user-home.component.css']
})
export class UserHomeComponent implements OnInit {
username:string;
usertype:string;
list:any;
  constructor(private service:ProductService, private router:Router) { 
    this.username =this.service.username;
    this.usertype = this.service.usertype;
  }

  ngOnInit(): void {
  }
  getallipo()
{
  
    this.service.getallIPO().subscribe(i=>{
      this.list = i;
      console.log(this.list);
    });

}
}
