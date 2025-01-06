using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiEducation2._0API.Domain.Entities
{
	public class Student
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime EnrollmentDate { get; set; }

		// Navigation Property
		public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
	}
}
