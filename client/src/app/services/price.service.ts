import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class PriceService {
  private prices: Record<string, number> = {};

  setPrice(category: string, price: number) {
    this.prices[category] = price;
  }

  getPrice(category: string): number {
    return this.prices[category] ?? 0;
  }

  syncCategory(category: string, items: any[]) {
    const price = this.getPrice(category);
    items.forEach(i => { if (i.category === category) i.userPrice = price; });
  }
}