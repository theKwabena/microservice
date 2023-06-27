using microservice.Models;

namespace microservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Todo> GetTodos();
        Todo getTodobyID(int todoID);

        void insertTodo(Todo todo);

        void deleteTodo(int todoID);

        void updateTodo(Todo todo);

        void Save();
    }
}
