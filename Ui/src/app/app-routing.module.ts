import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { componentFactoryName } from '@angular/compiler';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { UserHomeComponent } from './user-home/user-home.component';
import { RegisterComponent } from './register/register.component';
import { CompanyComponent } from './company/company.component';
import { StockExchangeComponent } from './stock-exchange/stock-exchange.component';
import { IPOComponent } from './ipo/ipo.component';
import { IPOdisplayComponent } from './ipodisplay/ipodisplay.component';
import { ChartsComponent} from './charts/charts.component'
import {SectordisplayComponent} from './sectordisplay/sectordisplay.component'
const routes: Routes = [
 {path:'Login',component: LoginComponent},
 {path:'Admin', component: AdminComponent},
 {path:'UserHome', component: UserHomeComponent},
 {path:'',redirectTo:'Login',pathMatch:"full"},
 {path:'SignUp', component:RegisterComponent},
 {path:'company', component:CompanyComponent},
 {path:'StockExchange', component:StockExchangeComponent},
 {path:'ipo', component:IPOComponent},
 {path:'ipodisplay', component: IPOdisplayComponent},
 {path:'chart', component: ChartsComponent},
 {path:'sectorchart',component:SectordisplayComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
