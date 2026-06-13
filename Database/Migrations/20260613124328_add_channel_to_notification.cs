using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notification_service.Database.Migrations
{
    /// <inheritdoc />
    public partial class add_channel_to_notification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "channel",
                table: "notifications",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "channel",
                table: "notifications");
        }
    }
}
