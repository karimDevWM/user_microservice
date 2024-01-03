﻿using userMicroservice.Model;

namespace userMicroservice.Data.Repository.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int userId);

        Task<User> CreateUserAsync(User user);

        Task<User> UpdateUserAsync(User user);

        Task<User> DeleteUserAsync(User user);
    }
}
