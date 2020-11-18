import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
import { IPOdetails} from '../ipodetails'
@Component({
  selector: 'app-ipodisplay',
  templateUrl: './ipodisplay.component.html',
  styleUrls: ['./ipodisplay.component.css']
})
export class IPOdisplayComponent implements OnInit {
list:any;
  constructor(private service : ProductService, private router:Router) { }

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
