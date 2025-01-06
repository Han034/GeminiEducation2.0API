using GeminiEducation2._0API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiEducation2._0API.Persistence.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasKey(s => s.Id);

			builder.Property(s => s.FirstName)
				.IsRequired()
				.HasMaxLength(255);

			builder.Property(s => s.LastName)
				.IsRequired()
				.HasMaxLength(255);

			builder.Property(s => s.EnrollmentDate)
				.HasColumnType("date");
		}
	}
}
