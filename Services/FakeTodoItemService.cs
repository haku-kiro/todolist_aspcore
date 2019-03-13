using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;
using Vue2Spa.Providers; // I'll be keeping my interfaces here
using Microsoft.Extensions.Configuration;

namespace Vue2Spa.Services
{
    public class FakeTodoItemService : dbconnector, ITodoItemService
    {
        private readonly IConfiguration configuration;
        
        public FakeTodoItemService(IConfiguration config): base(config)
        {
            configuration = config;
        }

        public Task<IEnumerable<TodoItemModel>> GetTodoItems(string userId)
        {
            var todos = new []
            {
                new TodoItemModel() { Text = "Learn Vue.js", Completed = true },
                new TodoItemModel() { Text = "Learn ASP.NET core"  }
            };
            
            return Task.FromResult(todos.AsEnumerable());
        }

        public Task AddItem(string userId, string text)
        {
            var doc = CreateTodoItem(text);
            InsertDocument(doc);

            //Read up on what to actually return here
            return new Task(() => { Console.WriteLine("Done");});
        }

        public Task DeleteItem(string userId, Guid id)
        {
            throw new NotImplementedException();
        }


        public Task UpdateItem(string userId, Guid id, TodoItemModel updatedData)
        {
            throw new NotImplementedException();
        }
    }
}