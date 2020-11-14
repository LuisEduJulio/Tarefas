import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddAssignmentComponent } from './add-assignment/add-assignment.component';
import { DetailAssignmentComponent } from './detail-assignment/detail-assignment.component';
import { AssignmentComponent } from './assignment/assignment.component';


const routes: Routes = [
    { path: 'home', component: AppComponent, data: { title: 'Home' } },
    { path: 'categorias', component: CategoryComponent, data: { title: 'Catergorias' } },
    { path: 'adicionarCategoria', component: AddCategoryComponent, data: { title: 'AdicionarCategoria' } },
    { path: 'adicionarTarefa', component: AddAssignmentComponent, data: { title: 'AdicionarTarefa' } },
    { path: 'detalhe', component: DetailAssignmentComponent, data: { title: 'Detalhe' } },
    { path: 'tarefas', component: AssignmentComponent, data: { title: 'Tarefas' } },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class appRountingModule { }