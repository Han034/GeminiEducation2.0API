﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiEducation2._0API.Domain.Entities
{
	public class Lesson
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
	}
}