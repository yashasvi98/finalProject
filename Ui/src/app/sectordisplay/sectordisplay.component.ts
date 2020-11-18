import { Component, OnInit } from '@angular/core';
import { ChartDataSets, ChartOptions } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-sectordisplay',
  templateUrl: './sectordisplay.component.html',
  styleUrls: ['./sectordisplay.component.css']
})
export class SectordisplayComponent implements OnInit {
  lineChartData: ChartDataSets[]= [
    { data: [85, 72, 78, 75, 77, 75], label: 'Crude oil prices' },
  ];

  lineChartLabels: Label[] = ['1', '2', '3', '4', '5', '6'];

  lineChartOptions = {
    responsive: true,
  };

  lineChartColors: Color[] = [
    {
      borderColor: 'black',
      backgroundColor: 'rgba(255,255,0,0.28)',
    },
  ];

  lineChartLegend = true;
  lineChartPlugins = [];
  lineChartType :string;

  Sectorname:string;
  fromdate:Date;
  todate:Date;
  fromtime:string;
  totime:string;
  type:string;

  displaychart=false;

  list:number[];
  constructor(private service : ProductService, private router:Router) { }

  ngOnInit(): void {
  }
  display()
  {
    this.displaychart=true;
    console.log(this.Sectorname,this.fromdate,this.fromtime,this.todate,this.totime,this.type);
    this.lineChartType = this.type;
    this.service.getsectorpricelist(this.Sectorname,this.fromdate,this.todate,this.fromtime,this.totime).subscribe(i=>{
      this.list=i;
      console.log(this.list);
      this.lineChartData = [
          { data: this.list, label: 'Sector Price' },
        ];
    });

}
}