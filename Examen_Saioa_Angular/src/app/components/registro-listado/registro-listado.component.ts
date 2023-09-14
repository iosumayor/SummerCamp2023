import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { IPersonaCrear } from 'src/app/interfaces/persona/persona-crear-interface';
import { IPersona } from 'src/app/interfaces/persona/persona-interface';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-registro-listado',
  templateUrl: './registro-listado.component.html',
  styleUrls: ['./registro-listado.component.css']
})
export class RegistroListadoComponent implements OnInit, OnDestroy {
  listPersonas: IPersona[] = [];
  registroFG: FormGroup;
  sub!: Subscription;

  constructor(private fb: FormBuilder, private personaService: PersonaService) {
    this.registroFG = this.fb.group({
      nombre: ['', Validators.required],
      fechaNacimiento: ['', Validators.required],
      telefono: [null]
    });
  }

  ngOnInit(): void {
    this.obtenerPersonas();
  }

  obtenerPersonas(): void {
    this.sub = this.personaService.getPersonas().subscribe({
      next: (data) => {
        this.listPersonas = data;
      }, error: (error) => {
        console.log(error.error.titles ?? 'Algo salio mal');
      }
    });
  }

  registrarPersona(): void {
    const personaCrearDTO: IPersonaCrear = {
      nombre: this.registroFG.value.nombre,
      fechaNacimiento: this.registroFG.value.fechaNacimiento,
      telefono: this.registroFG.value.telefono,
    };
    console.log(personaCrearDTO);

    this.sub = this.personaService.register(personaCrearDTO).subscribe({
      next: (data) => {
        console.log('Usuario creado correctamente');
        this.obtenerPersonas();
        this.resetRegistroFG();
      }, error: (error) => {
        console.log(error.error.titles ?? 'Algo salio mal');
        this.obtenerPersonas();
      }
    });
    
  }

  resetRegistroFG(): void {
    this.registroFG.reset();
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

}
