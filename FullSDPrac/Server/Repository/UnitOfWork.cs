using FullSDPrac.Server.Data;
using FullSDPrac.Server.IRepository;
using FullSDPrac.Server.Models;
using FullSDPrac.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FullSDPrac.Server.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Manager> _managers;
        private IGenericRepository<TaskItem> _taskitems;
        private IGenericRepository<User> _users;

        private UserManager<ApplicationUser> _userManager;


        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Manager> Managers
        => _managers ??= new GenericRepository<Manager>(_context);
        public IGenericRepository<TaskItem> TaskItems
            => _taskitems ??= new GenericRepository<TaskItem>(_context);
        public IGenericRepository<User> Users
            => _users ??= new GenericRepository<User>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);


            await _context.SaveChangesAsync();

        }
    }
}




