using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Providers;

/// <summary>
/// The api/[contorller] transalates to api/todo
/// </summary>
namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class TodoController: Controller
    {
        // Notice we use the interface name (DI - so that if we change the implementation, we don't have to change it everywhere)
        private readonly ITodoItemService _todoItemService;

        // DI
        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        // Handle GET /api/todo
        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            // TODO: Get to-do items and return to the frontend
            var userId = "123"; // TODO: Get actual user id
            var todos = await _todoItemService.GetTodoItems(userId);

            return Ok(todos);
        }
    }

    [Route("api/[controller]")]
    public class NewNoteController: Controller
    {
        private readonly ITodoItemService _todoItemService;

        public NewNoteController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        /// <summary>
        /// Will eventually be a post with the text for the todo and the user id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public void AddItem()
        {
            _todoItemService.AddItem("123", "This is a random note!");
        }
    }
}