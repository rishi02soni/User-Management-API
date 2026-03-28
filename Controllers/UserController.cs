using Microsoft.AspNetCore.Mvc;
using UserManagement.Models;
using UserManagement.Services;

namespace UserManagement.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetUsers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _service.GetUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            var created = await _service.CreateUser(user);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, User user)
        {
            var updated = await _service.UpdateUser(id, user);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteUser(id);
            if (!deleted) return NotFound();
            return Ok();
        }
    }
}
