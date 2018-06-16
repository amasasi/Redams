import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common"
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home.component'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NewProjectComponent } from './../Project/new-project/new-project.component'
import { HomeChildComponent } from './homechild.component'
const HomeRoutes: Routes = [
  {
    path: '',
    redirectTo: 'Home/RedamsHome',
    pathMatch:'full'


  },
    {
      path: 'Home',
      component: HomeComponent,

      children:
        [
          {
            path: 'RedamsHome',
            component: HomeChildComponent

          },
          {
            path: 'NewProject',
            component: NewProjectComponent

          }

        ]
  }

  
];

@NgModule({
  imports: [CommonModule, FormsModule, RouterModule.forChild(HomeRoutes)],
  exports: [RouterModule],
  providers: [],
  declarations: [HomeComponent, HomeChildComponent]
})
export class HomeRoutingModule { }
