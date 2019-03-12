using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    public interface ITodoItemService
    {
        /// <summary>
        /// Returns an enumerable list of todo items for the passed user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IEnumerable<TodoItemModel>> GetTodoItems(string userId);

        /// <summary>
        /// Add a todo item to the passed user, with the passed text as the content of the 
        /// todo item.  
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        Task AddItem(string userId, string text);
        
        /// <summary>
        /// Sets the passed todo note as the updated items value
        /// for the specific user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <param name="updatedData"></param>
        /// <returns></returns>
        Task UpdateItem(string userId, Guid id, TodoItemModel updatedData);

        /// <summary>
        /// Removes the todo item, specified by the guid for the specified user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteItem(string userId, Guid id);
    }
}