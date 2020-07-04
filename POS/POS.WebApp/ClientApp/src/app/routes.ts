import { HomeComponent } from "./home/HomeComponent";
import { Routes } from '@angular/router';
import { AuthGuard } from './_guard/auth.guard';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  //{
  //  path: ''
  //  //runGuardsAndResolvers: 'always',
  //  //canActivate: [AuthGuard],
  //  children: [
  //    //{ path: 'lists', component: ListsComponent },
  //    //{ path: 'members', component: MemberListComponent, resolve: { users: MemberListResolver } },
  //    //{ path: 'members/:id', component: MemberDetailComponent, resolve: { user: MemberDetailResolver } },
  //    //{
  //    //  path: 'member/edit', component: MemberEditComponent,
  //    //  resolve: { user: MemberEditResolver },
  //    //  canDeactivate: [PreventUnsavedChanges]
  //    //},
  //    //{ path: 'messages', component: MessagesComponent }
  //  ]
  //},
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
