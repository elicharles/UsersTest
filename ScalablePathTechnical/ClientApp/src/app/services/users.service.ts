import { Injectable } from '@angular/core';
import {HttpClient } from '@angular/common/http';
import { Subject, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UserModel } from '../models/user.model';

@Injectable({
    providedIn: 'root'
})
export class UsersService {
    public userChanged = new Subject<UserModel[]>();
    public users: UserModel[] = [];

    constructor(private httpClient: HttpClient){
        this.httpClient.get<UserModel[]>(`${environment.apiUrl}/api/TaskItems`).subscribe((list) => {
            this.users = list;
            this.userChanged.next(list);
        }
        )
    }
}
