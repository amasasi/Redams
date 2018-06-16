import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';

import { HomeModule } from './home/home.module';
import { ProjectModule } from './Project/project.module'


@NgModule({
  declarations: [
    AppComponent,
   
   
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule, HomeModule,
    FormsModule, ProjectModule,
    RouterModule.forRoot([
      
    
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
