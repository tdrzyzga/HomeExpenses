using HomeExpenses.Domain.Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HomeExpenses.Domain
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HomeExpensesDbContext>(options =>
                                                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
