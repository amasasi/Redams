
import { Component, Inject } from '@angular/core';
import { Project } from './../../shared/redams.model.type'
import { HttpClient } from '@angular/common/http'
import { Router } from '@angular/router'
@Component({
  selector: 'my-component',
  templateUrl: './new-project.component.html'
})
export class NewProjectComponent {

  public project: Project;

  constructor(private router: Router, @Inject('BASE_URL') private _baseUrl: string, private http: HttpClient) {

    this.project = new Project();
  }



  public CreateProject(): void
  {
    var url = this._baseUrl + "api/Project";
    this.http.post <Project>(this._baseUrl + "api/Project", this.project).subscribe(result => {

      this.router.navigateByUrl("/projectdetail/" + result.ID)
     
    }, error => { })

  }
}
