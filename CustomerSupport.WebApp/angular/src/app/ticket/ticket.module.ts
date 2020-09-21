import { CommonModule } from '@angular/common';
import { NgModule } from "@angular/core";
import { CreateOrEditTicketComponent } from './create-ticket/create-edit-ticket.component';
import { ListTicketComponent } from './list-ticket/list-ticket.component';
import { TicketRoutingModule } from './ticket.routing.module';
import {TableModule} from 'primeng/table';
import {CalendarModule} from 'primeng/calendar';
import {SliderModule} from 'primeng/slider';
import {DialogModule} from 'primeng/dialog';
import {MultiSelectModule} from 'primeng/multiselect';
import {ContextMenuModule} from 'primeng/contextmenu';
import {ButtonModule} from 'primeng/button';
import {ToastModule} from 'primeng/toast';
import {InputTextModule} from 'primeng/inputtext';
import {ProgressBarModule} from 'primeng/progressbar';
import {DropdownModule} from 'primeng/dropdown';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
    imports: [
        CommonModule,
        TicketRoutingModule,
        BrowserModule,
        BrowserAnimationsModule,
        TableModule,
        CalendarModule,
        SliderModule,
        DialogModule,
        MultiSelectModule,
        ContextMenuModule,
        DropdownModule,
        ButtonModule,
        ToastModule,
        InputTextModule,
        ProgressBarModule,
        FormsModule,
        ToastrModule.forRoot(),
        ReactiveFormsModule
    ],
    declarations:[
        ListTicketComponent,
        CreateOrEditTicketComponent
    ]
})
export class TicketModule { }
