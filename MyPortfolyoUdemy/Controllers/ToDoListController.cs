﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.ToDoList.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatToDoList()
        {
            return View();

        }

        [HttpPost]
        public IActionResult CreatToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoList.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoList.Find(id);
            context.ToDoList.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoList.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.ToDoList.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value=context.ToDoList.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = context.ToDoList.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
