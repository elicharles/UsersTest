import { Injectable } from '@angular/core';
import {HttpClient } from '@angular/common/http';
import {User} from '../models/users.model';
import { Subject, Observable } from 'rxjs';
import { UserModel } from '../models/user.model';

@Injectable({
    provideIn: 'root'
})
export class UsersService {
    public userChanged = new Subject<UserModel[]>();
    public users: User[] = [];

    constructor(private httpClient: HttpClient){
        this.httpClient.get<User[]>('').subscribe((list) => {
            this.users = list;
            this.userChanged.next(list);
        }
        )
    }
}