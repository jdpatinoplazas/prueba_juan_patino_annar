import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly apiUrl = 'http://localhost:5083/api/';

  constructor( private http: HttpClient) { }

  //PACIENTE
  getPacienteList(): Observable<any[]>{
    return this.http.get<any[]>(this.apiUrl + 'PacienteDetalles/GetPacienteDetalles');
  }
  addPaciente(pac: any): Observable<any>{
    const httpOptions = {Headers: new HttpHeaders({ 'Content-Type': 'application/json'})};
    return this.http.post<any>(this.apiUrl + 'PacienteDetalles/PostPacienteDetalle', pac, httpOptions);
  }
  updatePaciente(pac: any): Observable<any>{
    const httpOptions = {Headers: new HttpHeaders({ 'Content-Type': 'application/json'})};
    return this.http.put<any>(this.apiUrl + 'PacienteDetalles/PutPacienteDetalle', pac, httpOptions);
  }
  deletePaciente(pacId: number): Observable<any>{
    const httpOptions = {Headers: new HttpHeaders({ 'Content-Type': 'application/json'})};
    return this.http.delete<number>(this.apiUrl + 'PacienteDetalles/DeletePacienteDetalle/'+ pacId, httpOptions);
  }
}
