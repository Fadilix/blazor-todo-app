using BlazorTodoApp.Context;
using BlazorTodoApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;

namespace BlazorTodoApp.Services
{
    public class TodoService
    {
        public readonly AppDbContext _db;

        public TodoService(AppDbContext db)
        {
            _db = db;
        }

        // get all todos

        public async Task<List<Todo>> GetAllTodos()
        {
            return await _db.Todos.ToListAsync();
        }


        // get a todo by id

        public async Task<Todo> GetTodoById(int id)
        {
            return await _db.Todos.FindAsync(id);
        }


        // add a todo
        public async Task<bool> AddTodoAsync(Todo todo)
        {
            await _db.Todos.AddAsync(todo);
            await _db.SaveChangesAsync();
            return true;
        }


        // Get todos for a user
        //public async Task<List<Todo>> GetTodosForUser(int userId)
        //{
        //    return await _db.Todos.Where(t => t.UserId == userId).ToListAsync();
        //}

        public async Task<bool> UpdateTodo(Todo todo)
        {
            _db.Todos.Update(todo);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteATodo(int id)
        {
            var todo = await _db.Todos.FindAsync(id);
            if (todo == null)
                return false;

            _db.Todos.Remove(todo);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTodo(Todo todo)
        {
            _db.Todos.Remove(todo);
            await _db.SaveChangesAsync();
            return true;
        }


    }
}
