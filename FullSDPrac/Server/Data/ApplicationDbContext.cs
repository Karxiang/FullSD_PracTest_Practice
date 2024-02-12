using Duende.IdentityServer.EntityFramework.Options;
using FullSDPrac.Server.Models;
using FullSDPrac.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FullSDPrac.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Shared.Domain.TaskItem> TaskItems { get; set; } //its supposed do just be DbSet<Task> Tasks {get;set;} but there is another thing call tasked as well... this is just to specific a single 1
        public DbSet<Manager> Managers { get; set; }
        public DbSet<User> Users {  get; set; }
    }
}
