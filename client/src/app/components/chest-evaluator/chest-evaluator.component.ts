import { Component, OnInit } from '@angular/core';
import { PriceService } from '../../services/price.service';
import { HttpClient } from '@angular/common/http';
import { Chest } from '../../models/chest.model';
import { LootItem } from '../../models/loot-item.model';



@Component({
  selector: 'app-chest-evaluator',
  templateUrl: './chest-evaluator.component.html',
  styleUrls: ['./chest-evaluator.component.scss'],
})
export class ChestEvaluatorComponent implements OnInit {
  stages = [
    'Etage 230–269 (Fantastique)',
    'Etage 270–323 (Imaginaire)',
    'Etage 324+ (Brumeux)',
  ];
  selectedStage = '';
  chests: Chest[] = [];
  selectedChest: Chest | null = null;
  groupedOutcomes: LootItem[][] = [];

  totalPrice = 0;

  trackByIndex(idx: number): number {
    return idx;
  }

  // helper to use in *ngFor trackBy for individual loot items
  trackByName(_: number, item: LootItem): string {
    return item.name;
  }



  constructor(
    private priceService: PriceService,
    private http: HttpClient
  ) {}

  ngOnInit() {
    // initially no chests; they load on stage change
  }

  onStageChange() {
  this.selectedChest = null;
  this.totalPrice    = 0;

  const url = `/api/chests?stage=${encodeURIComponent(this.selectedStage)}`;
  this.http.get<Chest[]>(url)
    .subscribe(
      data => {
        console.log('Chest data from API:', data);
        this.chests = data;
      },
      err => console.error('API error:', err)
    );
}
private chunk<T>(arr: T[], size: number): T[][] {
    const groups: T[][] = [];
    for (let i = 0; i < arr.length; i += size) {
      groups.push(arr.slice(i, i + size));
    }
    return groups;
  }



  selectChest(chest: Chest) {
    // Keep the raw chest
    this.selectedChest = chest;

    // 1) Attach an imagePath to each outcome if not already present
    chest.outcomes.forEach(o => {
      o.imagePath = `assets/${o.category.toLowerCase()}.png`;
      // default quantity is already in the model
    });

    // 2) Build your columns: 5 items each
    this.groupedOutcomes = this.chunk(chest.outcomes, 5);

    // reset price
    this.totalPrice = 0;
  }



  onPriceChange(item: LootItem) {
    this.priceService.setPrice(item.category, item.userPrice);
    this.priceService.syncCategory(item.category, this.selectedChest!.outcomes);
    this.calculateTotal();
  }

  calculateTotal() {
    this.totalPrice = this.selectedChest!.outcomes.reduce(
      (sum, i) => sum + i.probability * (i.userPrice || 0),
      0
    );
  }
}