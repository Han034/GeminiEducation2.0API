using GeminiEducation2._0API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeminiEducation2._0API.Persistence.Configurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(c => c.Id);

			builder.Property(c => c.Title)
				.IsRequired()
				.HasMaxLength(255);

			builder.Property(c => c.Description)
				.IsRequired();

			builder.Property(c => c.Price)
				.HasColumnType("decimal(18,2)");

			builder.HasOne(c => c.Category)
				.WithMany(cat => cat.Courses)
				.HasForeignKey(c => c.CategoryId)
				.OnDelete(DeleteBehavior.Restrict); // Kategori silindiğinde kursun silinmesini engelle

			builder.HasOne(c => c.Instructor)
				.WithMany(i => i.Courses)
				.HasForeignKey(c => c.InstructorId)
				.OnDelete(DeleteBehavior.Restrict); // Eğitmen silindiğinde kursun silinmesini engelle
		}
	}
}
