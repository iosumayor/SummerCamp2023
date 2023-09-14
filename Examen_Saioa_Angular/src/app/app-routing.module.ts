import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegistroListadoComponent } from './components/registro-listado/registro-listado.component';

const routes: Routes = [
  { path: '', redirectTo: '/personas', pathMatch: 'full' },
  { path: 'personas', component: RegistroListadoComponent },
  { path: '**', redirectTo: '/personas', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
