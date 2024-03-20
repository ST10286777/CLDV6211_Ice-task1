using CLDV_ICE_TASK.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using CLDV_ICE_TASK.Models;
using CLDV_ICE_TASK.Data;

namespace IceTask1.Models;

public static class Data
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CLDV_ICE_TASKContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CLDV_ICE_TASKContext>>()))
        {
            // Look for any task.
            if (context.TaskManager.Any())
            {
                return;   // DB has been seeded
            }
            context.TaskManager.AddRange(
                new TaskManager
                {
                    TaskName = "CLDV- Ice task 1",
                    Taskdetails = "Create web app",
                    Deadline = DateTime.Parse("2024-5-12"),
                    Status = "Completed"

                },
                new TaskManager
                {
                    TaskName = "CLDV- Ice task 1",
                    Taskdetails = "Create web app",
                    Deadline = DateTime.Parse("2024-5-12"),
                    Status = "Completed"
                },
                new TaskManager
                {
                    TaskName = "CLDV- Ice task 1",
                    Taskdetails = "Create web app",
                    Deadline = DateTime.Parse("2024-5-12"),
                    Status = "Completed"
                },
                new TaskManager
                {
                    TaskName = "CLDV- Ice task 1",
                    Taskdetails = "Create web app",
                    Deadline = DateTime.Parse("2024-5-12"),
                    Status = "Completed"
                }
            );
            context.SaveChanges();
        }
    }
}
