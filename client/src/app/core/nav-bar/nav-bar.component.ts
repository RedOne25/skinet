import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AccountService } from 'src/app/account/account.service';
import { BasketService } from 'src/app/basket/basket.service';
import { IBasket } from 'src/app/shared/models/basket';
import { IUser } from 'src/app/shared/models/user';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {
basket$: Observable<IBasket>;
currentUser$: Observable<IUser>;
activeClass: string;
selectedCategorie: string;

  constructor(private basketService: BasketService, private accountService: AccountService) { }

  ngOnInit(): void {
    this.basket$ = this.basketService.basket$;
    this.currentUser$ = this.accountService.currentUser$;
    this.selectedCategorie = 'Catégorie';
    this.activeClass = 'dropdown-item d-flex align-items-center py-2';
  }

  logout() {
    this.accountService.logout();
  }

  changeCategorie(categorie: string) {
    if (categorie !== this.selectedCategorie){
      this.activeClass = 'dropdown-item d-flex align-items-center py-2 active';
      this.selectedCategorie = categorie;
    }
    
  }
}
