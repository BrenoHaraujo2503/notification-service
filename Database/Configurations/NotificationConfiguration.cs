using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using notification_service.database.models;

namespace notification_service.database.configurations;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.ToTable("notifications");

        builder.HasKey(n => n.Id);

        builder.Property(n => n.Id)
            .HasColumnName("id")
            .HasDefaultValueSql("gen_random_uuid()");

        builder.Property(n => n.channel)
            .HasColumnName("channel")
            .IsRequired()
            .HasConversion<string>();

        builder.Property(n => n.Title)
            .HasColumnName("title")
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(n => n.Content)
            .HasColumnName("content")
            .IsRequired()
            .HasColumnType("text");

        builder.Property(n => n.ReadAt)
            .HasColumnName("read_at")
            .IsRequired(false);

        builder.Property(n => n.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired()
            .HasDefaultValueSql("now()");
    }
}