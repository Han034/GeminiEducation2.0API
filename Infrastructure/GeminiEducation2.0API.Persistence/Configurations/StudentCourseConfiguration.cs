﻿using GeminiEducation2._0API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiEducation2._0API.Persistence.Configurations
{
	public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
	{
		public void Configure(EntityTypeBuilder<StudentCourse> builder)
		{
			builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

			builder.HasOne(sc => sc.Student)
				.WithMany(s => s.StudentCourses)
				.HasForeignKey(sc => sc.StudentId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(sc => sc.Course)
				.WithMany(c => c.StudentCourses)
				.HasForeignKey(sc => sc.CourseId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
