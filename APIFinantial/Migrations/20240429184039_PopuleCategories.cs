using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFinantial.Migrations
{
    /// <inheritdoc />
    public partial class PopuleCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO categories(Name,CategoryType) VALUES('Salary', 0);");
            mb.Sql("INSERT INTO categories(Name,CategoryType) VALUES('Saúde', 1);");
            mb.Sql("INSERT INTO categories(Name,CategoryType) VALUES('Alimentação', 1);");
            mb.Sql("INSERT INTO categories(Name,CategoryType) VALUES('Comunicação', 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM categories");
        }
    }
}
