import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  //OSS. Convenzionalmente (non è una cosa obbligatoria quindi), quando si costruisce una classe si ordina così:
  //prima le proprietà
  title = 'Applicativo client Incontriamoci!';
  users: any;

  //poi il costruttore
  constructor(private http: HttpClient) {}

  //in fine i metodi
  ngOnInit(): void {
    //Qui dentro si può aggiungere il codice di inizializzazione che si preferisce
    //Ad esempio qui si può fare una richiesta al nostro Server API
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: response => this.users = response,
      error: error => console.log(error),
      complete: () => console.log('Request has completed')
    })
  }

}
