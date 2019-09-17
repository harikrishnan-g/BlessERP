import { Component, OnInit } from '@angular/core';
import { Tasks } from '../Model/Tasks';
import { TaskService } from '../_services/task.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Tasks',
  templateUrl: './Tasks.component.html',
  styleUrls: ['./Tasks.component.css']
})
export class TasksComponent implements OnInit {
  tasks: Tasks[];
  newTask: Tasks = new Tasks();

  constructor(private tasksService: TaskService) {}

  ngOnInit() {
    this.tasksService.getTasks().subscribe((response: Tasks[]) => {
      this.tasks = response;
    });
  }
  onSaveClick() {
    this.tasksService.postTasks(this.newTask).subscribe(
      response => {
        this.tasks.push(this.newTask);
      },
      error => {
        console.log(error);
      }
    );
  }
}
