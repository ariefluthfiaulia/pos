"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./home/home.component");
exports.appRoutes = [
    { path: '', component: home_component_1.HomeComponent },
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
//# sourceMappingURL=routes.js.map