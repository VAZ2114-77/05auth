﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs
{
	public class PostDto
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public bool IsPublished { get; set; }
	}
}
