using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.ComponentModel.DataAnnotations;

namespace To_DoList.Models
{
	public class Task
	{
        public int Id { get; set; }
		public string? Name { get; set; }
		[DataType(DataType.Date)]
		public DateTime CreatedDate { get; set;}
		public string? Description { get; set; }
    }
}