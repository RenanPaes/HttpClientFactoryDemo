using HttpClientFactory.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactory.API.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(int id);
    }
}
