import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { Assignment } from '../../model/Assignment';

@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.css']
})
export class AssignmentComponent implements OnInit {
  displayedColumns: string[] = [ 'Title', 'Describe','Finish'];
  dataSource: Assignment[];
  isLoadingResults = true;

  
  constructor(private api: ApiService) { }

  ngOnInit() {
    this.api.getAssignment()
    .subscribe(res => {
      this.dataSource = res;
      console.log(this.dataSource);
      this.isLoadingResults = false;
    }, err => {
      console.log(err);
      this.isLoadingResults = false;
    });
  }

}
