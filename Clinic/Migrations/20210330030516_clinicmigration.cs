using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.Migrations
{
    public partial class clinicmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aDweyas",
                columns: table => new
                {
                    id_adweya = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_adweya = table.Column<string>(nullable: true),
                    tel = table.Column<string>(nullable: true),
                    supplier_adweya = table.Column<string>(nullable: true),
                    uses_adwya = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aDweyas", x => x.id_adweya);
                });

            migrationBuilder.CreateTable(
                name: "iradats",
                columns: table => new
                {
                    id_irad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    irad_type = table.Column<string>(maxLength: 500, nullable: false),
                    addtime_irad = table.Column<DateTime>(nullable: false),
                    amount = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iradats", x => x.id_irad);
                });

            migrationBuilder.CreateTable(
                name: "masrofats",
                columns: table => new
                {
                    id_masrof = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masrof_type = table.Column<string>(maxLength: 500, nullable: false),
                    addtime_masrof = table.Column<DateTime>(nullable: false),
                    amount = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masrofats", x => x.id_masrof);
                });

            migrationBuilder.CreateTable(
                name: "onlines",
                columns: table => new
                {
                    id_online = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_online = table.Column<string>(maxLength: 50, nullable: false),
                    adress_online = table.Column<string>(maxLength: 250, nullable: true),
                    phone_online = table.Column<string>(nullable: false),
                    date_online = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_onlines", x => x.id_online);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    idpatiend = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<int>(nullable: false),
                    name_patient = table.Column<string>(maxLength: 50, nullable: false),
                    phone_patient = table.Column<string>(nullable: true),
                    adress_patient = table.Column<string>(maxLength: 250, nullable: true),
                    addtime = table.Column<DateTime>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    type_kashf = table.Column<string>(maxLength: 50, nullable: false),
                    notes = table.Column<string>(maxLength: 1000, nullable: false),
                    paied = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.idpatiend);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    id_clinic = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctor_name = table.Column<string>(nullable: true),
                    phone_clinic = table.Column<string>(nullable: true),
                    logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.id_clinic);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aDweyas");

            migrationBuilder.DropTable(
                name: "iradats");

            migrationBuilder.DropTable(
                name: "masrofats");

            migrationBuilder.DropTable(
                name: "onlines");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "settings");
        }
    }
}
