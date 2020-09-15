using JobSearch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSearch.Api.Database
{
    public class JobSearchContext : DbContext
    {
        public JobSearchContext(DbContextOptions<JobSearchContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
