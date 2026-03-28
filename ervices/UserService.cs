using UserManagement.Models;
using UserManagement.Repositories;

namespace UserManagement.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<User> CreateUser(User user)
        {
            return await _repo.AddAsync(user);
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return null;

            existing.Name = user.Name;
            existing.Email = user.Email;

            return await _repo.UpdateAsync(existing);
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await _repo.DeleteAsync(id);
        }
    }
}
