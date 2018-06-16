
import { Component, OnInit, Inject} from '@angular/core';
import { Project } from './../shared/redams.model.type'
import { ActivatedRoute, Params } from '@angular/router'
import { HttpClient } from '@angular/common/http'
@Component({
  selector: 'project-component',
  templateUrl: './project.component.html'
})
export class ProjectComponent implements OnInit {


  public Project: Project;

  ngOnInit(): void {


    this.route.params.subscribe((params: Params) => {

    


      var url = this._baseUrl + "api/Project/" + params['ProjectID'];
      
      this.http.get<Project>(url).subscribe(result => {

        this.Project = result;
      }, error => { })

    });
  }
  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) {
    
  }
}
