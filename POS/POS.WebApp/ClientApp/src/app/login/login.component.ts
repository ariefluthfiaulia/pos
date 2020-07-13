import { Component, OnInit, Renderer2, OnDestroy, Inject } from '@angular/core';
import { AuthService } from '../_service/auth.service';
import { AlertifyService } from '../_service/alertify.service';
import { Router } from '@angular/router';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy  {

  model: any = {};

  constructor(public authService: AuthService, private alertify: AlertifyService, private router: Router, @Inject(DOCUMENT) private document: Document,
    private renderer: Renderer2) { }

  ngOnInit() {
    this.renderer.addClass(this.document.body, 'body-login');
  }

  ngOnDestroy(): void {
    this.renderer.removeClass(this.document.body, 'body-login');
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('Login Successfully');
    }, err => {
      this.alertify.error(err);
    }, () => {
      this.router.navigate(['']);
    });
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

}
