import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common"
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { ProjectComponent } from './project.component';
import { NewProjectComponent } from './new-project/new-project.component'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
const projectsRoutes: Routes = [
  {
    path: 'project',
    component: ProjectComponent
    
  },
  {
    path: 'newproject',
    component: NewProjectComponent
  }
];

@NgModule({
  imports: [CommonModule, FormsModule, RouterModule.forChild(projectsRoutes)],
  exports: [RouterModule],
  providers: [],
  declarations: [ProjectComponent, NewProjectComponent]
})
export class ProjectRoutingModule { }
