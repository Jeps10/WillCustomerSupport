import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateOrEditTicketComponent } from './create-edit-ticket.component';

describe('CreateTicketComponent', () => {
  let component: CreateOrEditTicketComponent;
  let fixture: ComponentFixture<CreateOrEditTicketComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateOrEditTicketComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateOrEditTicketComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
