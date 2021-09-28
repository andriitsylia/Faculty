using Microsoft.EntityFrameworkCore.Migrations;

namespace Faculty.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Description", "Name" },
                values: new object[] { 1, "Course of the algebra", "Algebra" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Description", "Name" },
                values: new object[] { 2, "Course of the math analysis", "Math analysis" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Description", "Name" },
                values: new object[] { 3, "Course of the discrete mathematics", "Discrete mathematics" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "CourseId", "Name" },
                values: new object[,]
                {
                    { 3, 1, "SR-03" },
                    { 6, 1, "SR-06" },
                    { 2, 2, "SR-02" },
                    { 5, 2, "SR-05" },
                    { 1, 3, "SR-01" },
                    { 4, 3, "SR-04" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 3, "Andy_03", 3, "Jones_G_03" },
                    { 45, "Andy_45", 2, "Jones_G_02" },
                    { 60, "Andy_60", 2, "Jones_G_02" },
                    { 5, "Andy_05", 5, "Jones_G_05" },
                    { 7, "Andy_07", 5, "Jones_G_05" },
                    { 12, "Andy_12", 5, "Jones_G_05" },
                    { 18, "Andy_18", 5, "Jones_G_05" },
                    { 20, "Andy_20", 5, "Jones_G_05" },
                    { 27, "Andy_27", 5, "Jones_G_05" },
                    { 34, "Andy_34", 5, "Jones_G_05" },
                    { 41, "Andy_41", 5, "Jones_G_05" },
                    { 42, "Andy_42", 5, "Jones_G_05" },
                    { 46, "Andy_46", 5, "Jones_G_05" },
                    { 33, "Andy_33", 2, "Jones_G_02" },
                    { 58, "Andy_58", 5, "Jones_G_05" },
                    { 11, "Andy_11", 1, "Jones_G_01" },
                    { 24, "Andy_24", 1, "Jones_G_01" },
                    { 36, "Andy_36", 1, "Jones_G_01" },
                    { 37, "Andy_37", 1, "Jones_G_01" },
                    { 44, "Andy_44", 1, "Jones_G_01" },
                    { 47, "Andy_47", 1, "Jones_G_01" },
                    { 49, "Andy_49", 1, "Jones_G_01" },
                    { 54, "Andy_54", 1, "Jones_G_01" },
                    { 57, "Andy_57", 1, "Jones_G_01" },
                    { 16, "Andy_16", 4, "Jones_G_04" },
                    { 19, "Andy_19", 4, "Jones_G_04" },
                    { 21, "Andy_21", 4, "Jones_G_04" },
                    { 10, "Andy_10", 1, "Jones_G_01" },
                    { 32, "Andy_32", 2, "Jones_G_02" },
                    { 30, "Andy_30", 2, "Jones_G_02" },
                    { 29, "Andy_29", 2, "Jones_G_02" },
                    { 6, "Andy_06", 3, "Jones_G_03" },
                    { 13, "Andy_13", 3, "Jones_G_03" },
                    { 15, "Andy_15", 3, "Jones_G_03" },
                    { 22, "Andy_22", 3, "Jones_G_03" },
                    { 23, "Andy_23", 3, "Jones_G_03" },
                    { 38, "Andy_38", 3, "Jones_G_03" },
                    { 48, "Andy_48", 3, "Jones_G_03" },
                    { 52, "Andy_52", 3, "Jones_G_03" },
                    { 59, "Andy_59", 3, "Jones_G_03" },
                    { 4, "Andy_04", 6, "Jones_G_06" },
                    { 8, "Andy_08", 6, "Jones_G_06" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 14, "Andy_14", 6, "Jones_G_06" },
                    { 25, "Andy_25", 6, "Jones_G_06" },
                    { 31, "Andy_31", 6, "Jones_G_06" },
                    { 35, "Andy_35", 6, "Jones_G_06" },
                    { 40, "Andy_40", 6, "Jones_G_06" },
                    { 43, "Andy_43", 6, "Jones_G_06" },
                    { 50, "Andy_50", 6, "Jones_G_06" },
                    { 51, "Andy_51", 6, "Jones_G_06" },
                    { 53, "Andy_53", 6, "Jones_G_06" },
                    { 56, "Andy_56", 6, "Jones_G_06" },
                    { 1, "Andy_01", 2, "Jones_G_02" },
                    { 2, "Andy_02", 2, "Jones_G_02" },
                    { 9, "Andy_09", 2, "Jones_G_02" },
                    { 17, "Andy_17", 2, "Jones_G_02" },
                    { 26, "Andy_26", 2, "Jones_G_02" },
                    { 28, "Andy_28", 2, "Jones_G_02" },
                    { 39, "Andy_39", 4, "Jones_G_04" },
                    { 55, "Andy_55", 4, "Jones_G_04" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_CourseId",
                table: "Group",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
