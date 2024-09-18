using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using ApiDbContext dbContext =
            scope.ServiceProvider.GetRequiredService<ApiDbContext>();

        dbContext.Database.Migrate();
    }
}
