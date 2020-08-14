using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpClientFactory.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTodo(int id)
        {
            return Ok(await _todoService.GetTodo(id));
        }
    }
}
