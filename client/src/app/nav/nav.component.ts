import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable, of } from 'rxjs';
import { User } from '../_models/user';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};

  constructor(
    public accountService: AccountService, 
    private router: Router, 
    private toast: ToastrService) {}

  ngOnInit(): void {
  }

  login(){
    this.accountService.login(this.model).subscribe({
      next: () => {
        this.toast.success('Loggato con successo!'),
        this.router.navigateByUrl('/members')
      }
      //error: error => this.toast.error(error.error) //Non voglio gestire questo errore a vide, basta far vedere il 401 Unauthorazied
    })
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }

}
