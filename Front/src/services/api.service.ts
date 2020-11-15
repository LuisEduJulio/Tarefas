import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, tap } from 'rxjs/operators';
import { Assignment } from '../model/Assignment';

const apiUrl = 'https://localhost:5001/api/AssignmentContoller';
var httpOptions = { headers: new HttpHeaders({ "Content-Type": "application/json" })};

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }


  getAssignment (): Observable<Assignment[]> {
    try {
      console.log(httpOptions.headers);
      const res = this.http.get<Assignment[]>(apiUrl, httpOptions)
        .pipe(
          tap(Assignment => console.log('leu as tarefas')),
          catchError(this.handleError('getAssignment', []))
        );
      return res;
    } catch (err) {
      console.log(err)
    }
  }

  /*
  getCategoria(id: number): Observable<Categoria> {
    const url = `${apiUrl}/${id}`;
    return this.http.get<Categoria>(url, httpOptions).pipe(
      tap(_ => console.log(`leu a Categoria id=${id}`)),
      catchError(this.handleError<Categoria>(`getCategoria id=${id}`))
    );
  }

  addCategoria (Categoria): Observable<Categoria> {
    return this.http.post<Categoria>(apiUrl, Categoria, httpOptions).pipe(
      tap((Categoria: Categoria) => console.log(`adicionou a Categoria com w/ id=${Categoria.CategoriaId}`)),
      catchError(this.handleError<Categoria>('addCategoria'))
    );
  }

  updateCategoria(CategoriaId, Categoria): Observable<any> {
    const url = `${apiUrl}/${CategoriaId}`;
    return this.http.put(url, Categoria, httpOptions).pipe(
      tap(_ => console.log(`atualiza o produco com id=${CategoriaId}`)),
      catchError(this.handleError<any>('updateCategoria'))
    );
  }

  deleteCategoria (id): Observable<Categoria> {
    const url = `${apiUrl}/${id}`;
    return this.http.delete<Categoria>(url, httpOptions).pipe(
      tap(_ => console.log(`remove o Categoria com id=${id}`)),
      catchError(this.handleError<Categoria>('deleteCategoria'))
    );
  }
*/
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }
}