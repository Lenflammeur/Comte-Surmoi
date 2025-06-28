import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChestEvaluatorComponent } from './components/chest-evaluator/chest-evaluator.component';

const routes: Routes = [
  { path: 'chest-evaluator', component: ChestEvaluatorComponent },
  { path: '', redirectTo: 'chest-evaluator', pathMatch: 'full' },
  { path: '**', redirectTo: 'chest-evaluator' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }