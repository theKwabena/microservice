using microservice.Models;
using Microsoft.EntityFrameworkCore;

namespace microservice.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly apidbcontext _db;

        public TodoRepository(apidbcontext db)
        {
            _db = db;
           
        }
        public void deleteTodo(int todoID)
        {
            var product = _db.todos.Find(todoID);

            _db.todos.Remove(product);
            Save();
            throw new NotImplementedException();
        }

        public Todo getTodobyID(int todoID)
        {
            return _db.todos.Find(todoID);
        }

        public IEnumerable<Todo> GetTodos()
        {
            IEnumerable<Todo> todos = _db.todos;
            return todos;
        }

        public void insertTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void updateTodo(Todo todo)
        {
            _db.Entry(todo).State = EntityState.Modified;
            Save();
        }
    }
}
