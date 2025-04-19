using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Core.Models
{
	public class Post
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(200)]
		public string Title { get; set; }

		[Required]
		public string Content { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime? UpdatedAt { get; set; }

		[Required]
		public string AuthorId { get; set; }

		[ForeignKey("AuthorId")]
		public IdentityUser Author { get; set; }

		public bool IsPublished { get; set; } = false;
	}
}
