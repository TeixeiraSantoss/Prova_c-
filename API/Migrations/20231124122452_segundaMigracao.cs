﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class segundaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tarefas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 25, 9, 24, 51, 920, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 26, 9, 24, 51, 920, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 9, 24, 51, 920, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 1, 9, 24, 51, 920, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 9, 24, 51, 920, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 8, 9, 24, 51, 920, DateTimeKind.Local).AddTicks(9641));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tarefas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 25, 9, 21, 49, 669, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 26, 9, 21, 49, 669, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 9, 21, 49, 669, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 1, 9, 21, 49, 669, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 9, 21, 49, 669, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 8, 9, 21, 49, 669, DateTimeKind.Local).AddTicks(4951));
        }
    }
}
