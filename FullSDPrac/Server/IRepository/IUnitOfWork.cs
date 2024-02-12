using System.Drawing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullSDPrac.Shared.Domain;

namespace FullSDPrac.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<TaskItem> TaskItems { get; }
        IGenericRepository<Manager> Managers { get; }
        IGenericRepository<User> Users { get; }
    }
}
