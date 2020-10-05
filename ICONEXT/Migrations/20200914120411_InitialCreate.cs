using Microsoft.EntityFrameworkCore.Migrations;

namespace ICONEXT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.ID);
                });

            /////////////////////////////////////////////////////////////////////////////////////

            migrationBuilder.CreateTable(
                name: "outsource",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outsource", x => x.ID);
                });

            //////////////////////////////////////////////////////////////////////////////////

            

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {

                    ProjID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Partner = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.ProjID);
                });

            //////////////////////////////////////////////////////////////////////////////////

            migrationBuilder.CreateTable(
                name: "TaskProject",
                columns: table => new
                {

                    TID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tasks = table.Column<string>(nullable: true),
                    


                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.TID);
                });

            //////////////////////////////////////////////////////////////////////////////////

            migrationBuilder.CreateTable(
                name: "PhaseProject",
                columns: table => new
                {

                    PID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phase = table.Column<string>(nullable: true),
                    FromDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Usage = table.Column<string>(nullable: true),



                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.PID);
                });

            //////////////////////////////////////////////////////////////////////////////////


            



    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "outsource");

            migrationBuilder.DropTable(
               name: "project");

            migrationBuilder.DropTable(
              name: "TaskProject");

            migrationBuilder.DropTable(
              name: "PhaseProject");


        }
    }



       
}

