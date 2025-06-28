import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChestEvaluatorComponent } from './chest-evaluator.component';

describe('ChestEvaluatorComponent', () => {
  let component: ChestEvaluatorComponent;
  let fixture: ComponentFixture<ChestEvaluatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChestEvaluatorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChestEvaluatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
