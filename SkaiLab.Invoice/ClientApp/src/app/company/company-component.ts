import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'company-component',
  templateUrl: './company-component.html'
})
export class CompanyComponent  implements OnInit {
  constructor(private router:Router){

  }
  ngOnInit(): void {

  }

}

