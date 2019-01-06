import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipientCreateDialogComponent } from './recipient-create-dialog.component';

describe('RecipientCreateDialogComponent', () => {
  let component: RecipientCreateDialogComponent;
  let fixture: ComponentFixture<RecipientCreateDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecipientCreateDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecipientCreateDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
