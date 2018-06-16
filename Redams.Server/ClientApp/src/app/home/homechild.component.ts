
import { Component, Inject, OnInit } from '@angular/core';
import { Project } from './../shared/redams.model.type'
import { HttpClient } from '@angular/common/http'
@Component({
  selector: 'my-component',
  templateUrl: './homechild.component.html'
})
export class HomeChildComponent implements OnInit {
  constructor(private http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) {
    
  }



  public Projects: Project[]
  ngOnInit(): void {







    this.http.get<Project[]>(this._baseUrl + "api/Project").subscribe(result => {

      this.Projects = result;
    }, error => { })





  }
}
