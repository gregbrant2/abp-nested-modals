import { AuthService } from '@abp/ng.core';
import { Component } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  isModalOneOpen = false;
  isModalTwoOpen = false;

  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  constructor(private oAuthService: OAuthService, private authService: AuthService) {}

  login() {
    this.authService.initLogin();
  }

  openModalOne() {
    this.isModalOneOpen = true;
  }

  openModalTwo() {
    this.isModalTwoOpen = true;
  }
}
