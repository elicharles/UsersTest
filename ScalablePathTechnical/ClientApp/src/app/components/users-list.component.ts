import {Component, OnInit, OnDestroy} from '@angular/core';
import { UserModel} from '../models/user.model';
import { UsersService } from '../services/users.service';
import {Subscription} from 'rxjs';

@Component({
    selector: 'users-list',
    templateUrl: './users-list.component.html'
})
export class UsersListComponent implements OnInit, OnDestroy {
    public usersItems: UserModel[] = [];
    private usersChanged: Subscription;
    constructor(private usersListService: UsersService) {}
    ngOnInit(){
        this.usersItems = this.usersListService.users;
        this.usersChanged = this.usersListService.userChanged.subscribe((userItms) => {
            this.usersItems = userItms;
        })
    }
ngOnDestroy(): void {
    this.usersChanged.unsubscribe();
}
}

