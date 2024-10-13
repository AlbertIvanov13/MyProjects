using Microsoft.EntityFrameworkCore;
using To_DoList.Data;

namespace To_DoList.Models
{
	public static class SeedData
	{
		public static void Initialzie(IServiceProvider serviceProvider)
		{
			using (var context = new To_DoListContext(serviceProvider.GetRequiredService <DbContextOptions<To_DoListContext>>()))
			{
				if (context.Task.Any())
				{
					return;
				}
				context.Task.AddRange(
					new Task
					{
						Name = "Zadacha edno",
						CreatedDate = DateTime.Parse("2024-10-10"),
						Description = "Zadacha edno - pending"
					},
					new Task
					{
						Name = "Zadacha dve",
						CreatedDate = DateTime.Parse("2024-10-10"),
						Description = "Zadacha dve - pending"
					}
					);
				context.SaveChanges();
			}
		}
	}
}
