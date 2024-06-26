﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable // Wyłącza obsługę typów dopuszczających wartość null, co jest wymagane dla migracji.

namespace ProjektSklep.Migrations // Przestrzeń nazw dla migracji w projekcie.
{
    /// <inheritdoc />
    public partial class AddedOldPrice : Migration // Definicja migracji AddedOldPrice dziedzicząca z klasy Migration.
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) // Metoda definiująca zmiany do zastosowania podczas migracji w górę (aplikowanie migracji).
        {
            migrationBuilder.AddColumn<double>( // Dodawanie nowej kolumny.
                name: "OldPrice", // Nazwa nowej kolumny.
                table: "Products", // Tabela, do której dodawana jest kolumna.
                type: "REAL", // Typ danych nowej kolumny.
                nullable: false, // Wartość nie może być null.
                defaultValue: 0.0); // Domyślna wartość dla nowej kolumny.
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) // Metoda definiująca zmiany do zastosowania podczas migracji w dół (cofanie migracji).
        {
            migrationBuilder.DropColumn( // Usuwanie kolumny.
                name: "OldPrice", // Nazwa usuwanej kolumny.
                table: "Products"); // Tabela, z której usuwana jest kolumna.
        }
    }
}
