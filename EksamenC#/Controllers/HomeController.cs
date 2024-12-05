﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.BLL;
using DTO.Model;
using EksamenC_.Models;

namespace EksamenC_.Controllers {
    public class HomeController : Controller {

        public ActionResult Index()
        {
            var employees = populateListEmp();
            var tasks = populateListTask();

            var model = new TimeRegVM
            {
                EmployeeList = employees,
                TaskList = tasks
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Submit(TimeRegVM model)
        {
            // Process the selected value
            string selectedEmployee = model.SelectedEmployeeInitials;
            string selectedTask = model.SelectedTaskName;
            DateTime selectedStartTime = model.SelectedStartTime;
            DateTime selectedEndtime = model.SelectedEndTime;
            var tasks = TaskBll.getAllTasks();
            int tID = 0;
            foreach(var t in tasks)
            {
                if(t.Title == selectedTask)
                {
                    tID = t.TaskId;
                }
            }
            
            //Add TimeReg
            TimeRegBll.CreateTimeReg(selectedStartTime,selectedEndtime, selectedEmployee, tID);
            
            // Re-populate the employee list
            model.EmployeeList = populateListEmp();
            model.TaskList = populateListTask();
    
            return View("Index", model);
        }


        public List<SelectListItem> populateListEmp()
        {
            //Get Employees
            List<Employee> employees = EmployeeBll.GetAllEmployees();
            //Convert to SelectList
            var empSelectList = employees.Select(e => new SelectListItem
            {
                Text = e.Initials
            }).ToList();

            return empSelectList;
        }
        public List<SelectListItem> populateListTask()
        {
            List<Task> tasks = TaskBll.getAllTasks();
            var taskSelectList = tasks.Select(t => new SelectListItem
            {
                Text = t.Title
            }).ToList();

            return taskSelectList;
        }
    }
}