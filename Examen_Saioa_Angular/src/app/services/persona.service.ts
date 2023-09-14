import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPersona } from '../interfaces/persona/persona-interface';
import { Observable } from 'rxjs';
import { IPersonaCrear } from '../interfaces/persona/persona-crear-interface';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  myAppUrl: string;
  myApiUrl: string;

  constructor(private http: HttpClient) { 
    this.myAppUrl = 'https://localhost:7239/';
    this.myApiUrl = 'api/personas/';
  }

  register(personaDTO: IPersonaCrear): Observable<any> {
    return this.http.post(this.myAppUrl + this.myApiUrl + 'registro', personaDTO);
  }

  getPersonas(): Observable<IPersona[]> {
    return this.http.get<IPersona[]>(this.myAppUrl + this.myApiUrl);
  }

  
}
