using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItemModel>> GetTodoItems(string userId);

        Task AddItem(string userId, string text);
        
        Task UpdateItem(string userId, Guid id, TodoItemModel updatedData);

        Task DeleteItem(string userId, Guid id);
    }
}