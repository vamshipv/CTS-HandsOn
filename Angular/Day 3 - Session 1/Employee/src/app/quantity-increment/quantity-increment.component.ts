import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quantity-increment',
  templateUrl: './quantity-increment.component.html',
  styleUrls: ['./quantity-increment.component.css']
})
export class QuantityIncrementComponent {

  public IncrementResult : String = "";
  public button() : void {
    this.IncrementResult= "Click me button clicked";
  }
  public Numbers : number = 0;
  public Add() : void{
    this.Numbers++;
  }

  public AddandSub : number = 0;
  public flag : boolean = true;

  public Increment() : void {
    this.AddandSub++;
    if(this.AddandSub > 0) {
      this.flag = false;
    }
    else{
      this.flag = true;
    }
  }

  public Decrement() : void {
    this.AddandSub--;
    if(this.AddandSub > 0) {
      this.flag = false;
    }
    else{
      this.flag = true;
    }
  }
}
