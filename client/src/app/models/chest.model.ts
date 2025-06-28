import { LootItem } from './loot-item.model';

export interface Chest {
  displayName: string;   // or “name” if you prefer consistency
  stage: string;         // e.g. “Etage 230–269 (Fantastique)”
  imagePath: string;     // maps to /assets/…png
  outcomes: LootItem[];
}