import { HomeComponent } from "./home/HomeComponent";
import { Routes } from '@angular/router';
import { AuthGuard } from './_guard/auth.guard';
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { ProductComponent } from "./product/product.component";
import { UserComponent } from "./user/user.component";
import { UserResolver } from "./_resolvers/user/user.resolver";

export const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'user', component: UserComponent, resolve: { users: UserResolver } }
      //{ path: 'product', component: ProductComponent, resolve: { users: MemberListResolver } }
      //{ path: 'members/:id', component: MemberDetailComponent, resolve: { user: MemberDetailResolver } },
      //{
      //  path: 'member/edit', component: MemberEditComponent,
      //  resolve: { user: MemberEditResolver },
      //  canDeactivate: [PreventUnsavedChanges]
      //},
      //{ path: 'messages', component: MessagesComponent }
    ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
