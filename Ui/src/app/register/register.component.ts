import { Component, OnInit } from '@angular/core';
import {User} from '../user';
import {ProductService} from '../Shared/product.service';
import {Router} from '@angular/router';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  id:number;
  username :string;
  password:string;
  usertype:string;
  email:string;
  mobileno:number;
  confirmed:string;
  user:User;
  constructor(private service:ProductService,private router:Router) { 
    this.user = new User();
  }

  ngOnInit(): void {
    }
    SignUp()
    {
      this.user.Id = this.id;
      this.user.Username = this.username;
      this.user.Password = this.password;
      this.user.UserType = this.usertype;
      this.user.Email = this.email;
      this.user.MobileNumber = this.mobileno;
      this.user.Confirmed = "YES";

      console.log(this.user);

      this.service.signup(this.user).subscribe(i=>{
        console.log(i.toString());
      });
    }
}