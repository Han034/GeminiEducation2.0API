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
	public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
	{
		public void Configure(EntityTypeBuilder<Instructor> builder)
		{
			builder.HasKey(i => i.Id);

			builder.Property(i => i.FirstName)
				.IsRequired()
				.HasMaxLength(255);

			builder.Property(i => i.LastName)
				.IsRequired()
				.HasMaxLength(255);

			builder.Property(i => i.Bio)
				.HasMaxLength(1000);
		}
	}
}
