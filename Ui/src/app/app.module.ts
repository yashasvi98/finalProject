import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from "@angular/common/http";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import {FormsModule} from '@angular/forms';
import { AdminComponent } from './admin/admin.component';
import { UserHomeComponent } from './user-home/user-home.component';
import { CompanyComponent } from './company/company.component';
import { StockExchangeComponent } from './stock-exchange/stock-exchange.component';
import { IPOComponent } from './ipo/ipo.component';
import { IPOdisplayComponent } from './ipodisplay/ipodisplay.component';
import { ChartsModule } from 'ng2-charts';
import { ChartsComponent } from './charts/charts.component';
import { SectordisplayComponent } from './sectordisplay/sectordisplay.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    AdminComponent,
    UserHomeComponent,
    CompanyComponent,
    StockExchangeComponent,
    IPOComponent,
    IPOdisplayComponent,
    ChartsComponent,
    SectordisplayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ChartsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
