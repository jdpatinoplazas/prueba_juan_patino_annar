import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PacienteComponent } from './paciente/paciente.component';
import { AddEditPacienteComponent } from './paciente/add-edit-paciente/add-edit-paciente.component';
import { ShowPacienteComponent } from './paciente/show-paciente/show-paciente.component';
import { ApiserviceService } from './apiservice.service';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  

@NgModule({
  declarations: [
    AppComponent,
    PacienteComponent,
    AddEditPacienteComponent,
    ShowPacienteComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ApiserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
