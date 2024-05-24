using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        private static List<ToDoItem> tasks = new List<ToDoItem>
        {
            new ToDoItem { Id=123,Title="to complete c#",Description="don't miss it",DueDate=DateTime.UtcNow.AddDays(6),IsCompleted=false}
        };
        public IActionResult Index()
        {
            return View(tasks);
        }
    }
}
