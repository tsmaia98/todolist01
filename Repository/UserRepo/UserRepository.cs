
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserRepository
{
    private readonly DatabaseContext _context;

    public UserRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetUserByIdAsync(int Id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);
    }
    public async Task<User> GetOneUserByIdAsync(int Id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);
    }

    public async Task AddUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int Id)
    {
        var user = await _context.Users.FindAsync(Id);
        if (user != null)
        {
            _context.Users.Remove (user);
            await _context.SaveChangesAsync();
        }
    }
}
