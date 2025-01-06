using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiEducation2._0API.Domain.Entities
{
	public class Course
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int DurationInHours { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		// Navigation Properties (Gezinme Özellikleri)
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }

		public Guid InstructorId { get; set; }
		public Instructor Instructor { get; set; }

		public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
	}
}
