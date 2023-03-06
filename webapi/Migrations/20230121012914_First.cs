using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CADASTRO",
                columns: table => new
                {
                    IDREGISTRO = table.Column<Guid>(name: "ID_REGISTRO", type: "uniqueidentifier", nullable: false),
                    NROINSCRICAO = table.Column<int>(name: "NRO_INSCRICAO", type: "int", nullable: false),
                    DATAINSCRICAO = table.Column<DateTime>(name: "DATA_INSCRICAO", type: "datetime2", nullable: false),
                    NOMETIT = table.Column<string>(name: "NOME_TIT", type: "nvarchar(max)", nullable: false),
                    NASCTIT = table.Column<DateTime>(name: "NASC_TIT", type: "datetime2", nullable: false),
                    RGTIT = table.Column<string>(name: "RG_TIT", type: "nvarchar(max)", nullable: false),
                    CPFTIT = table.Column<string>(name: "CPF_TIT", type: "nvarchar(max)", nullable: false),
                    ESTCIVILTIT = table.Column<string>(name: "EST_CIVIL_TIT", type: "nvarchar(max)", nullable: false),
                    SEXOTIT = table.Column<string>(name: "SEXO_TIT", type: "nvarchar(1)", nullable: false),
                    NATURALTIT = table.Column<string>(name: "NATURAL_TIT", type: "nvarchar(max)", nullable: false),
                    NESCESPTITDESCRICAO = table.Column<string>(name: "NESC_ESP_TIT_DESCRICAO", type: "nvarchar(max)", nullable: true),
                    NOMEMAE = table.Column<string>(name: "NOME_MAE", type: "nvarchar(max)", nullable: false),
                    ENDERECO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENDERECONRO = table.Column<string>(name: "ENDERECO_NRO", type: "nvarchar(max)", nullable: false),
                    ENDERECOCOMP = table.Column<string>(name: "ENDERECO_COMP", type: "nvarchar(max)", nullable: false),
                    BAIRRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MUNICIPIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFONERES = table.Column<string>(name: "TELEFONE_RES", type: "nvarchar(max)", nullable: true),
                    TELEFONECEL = table.Column<string>(name: "TELEFONE_CEL", type: "nvarchar(max)", nullable: false),
                    EMPRESATIT = table.Column<string>(name: "EMPRESA_TIT", type: "nvarchar(max)", nullable: false),
                    PROFTIT = table.Column<string>(name: "PROF_TIT", type: "nvarchar(max)", nullable: false),
                    RENDATIT = table.Column<string>(name: "RENDA_TIT", type: "nvarchar(max)", nullable: false),
                    ENDCOMERCIALTIT = table.Column<string>(name: "END_COMERCIAL_TIT", type: "nvarchar(max)", nullable: false),
                    NROCOMERCIALTIT = table.Column<string>(name: "NRO_COMERCIAL_TIT", type: "nvarchar(max)", nullable: false),
                    BAIRROCOMERCIALTIT = table.Column<string>(name: "BAIRRO_COMERCIAL_TIT", type: "nvarchar(max)", nullable: false),
                    CEPCOMERCIALTIT = table.Column<string>(name: "CEP_COMERCIAL_TIT", type: "nvarchar(max)", nullable: false),
                    MUNICOMERCIALTIT = table.Column<string>(name: "MUNI_COMERCIAL_TIT", type: "nvarchar(max)", nullable: false),
                    NOMECON = table.Column<string>(name: "NOME_CON", type: "nvarchar(max)", nullable: true),
                    NASCCON = table.Column<DateTime>(name: "NASC_CON", type: "datetime2", nullable: true),
                    RGCON = table.Column<string>(name: "RG_CON", type: "nvarchar(max)", nullable: true),
                    CPFCON = table.Column<string>(name: "CPF_CON", type: "nvarchar(max)", nullable: true),
                    ESTCIVILCON = table.Column<string>(name: "EST_CIVIL_CON", type: "nvarchar(max)", nullable: true),
                    SEXOCON = table.Column<string>(name: "SEXO_CON", type: "nvarchar(1)", nullable: true),
                    NATURALCON = table.Column<string>(name: "NATURAL_CON", type: "nvarchar(max)", nullable: true),
                    NESCESPCONDESCRICAO = table.Column<string>(name: "NESC_ESP_CON_DESCRICAO", type: "nvarchar(max)", nullable: true),
                    EMPRESACON = table.Column<string>(name: "EMPRESA_CON", type: "nvarchar(max)", nullable: true),
                    PROFCON = table.Column<string>(name: "PROF_CON", type: "nvarchar(max)", nullable: true),
                    RENDACON = table.Column<string>(name: "RENDA_CON", type: "nvarchar(max)", nullable: true),
                    ENDCOMERCIALCON = table.Column<string>(name: "END_COMERCIAL_CON", type: "nvarchar(max)", nullable: true),
                    NROCOMERCIALCON = table.Column<string>(name: "NRO_COMERCIAL_CON", type: "nvarchar(max)", nullable: true),
                    BAIRROCOMERCIALCON = table.Column<string>(name: "BAIRRO_COMERCIAL_CON", type: "nvarchar(max)", nullable: true),
                    CEPCOMERCIALCON = table.Column<string>(name: "CEP_COMERCIAL_CON", type: "nvarchar(max)", nullable: true),
                    MUNICOMERCIALCON = table.Column<string>(name: "MUNI_COMERCIAL_CON", type: "nvarchar(max)", nullable: true),
                    DEP1NOME = table.Column<string>(name: "DEP1_NOME", type: "nvarchar(max)", nullable: true),
                    DEP1PAREN = table.Column<string>(name: "DEP1_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP1NASC = table.Column<string>(name: "DEP1_NASC", type: "nvarchar(max)", nullable: true),
                    DEP1RENDA = table.Column<string>(name: "DEP1_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP2NOME = table.Column<string>(name: "DEP2_NOME", type: "nvarchar(max)", nullable: true),
                    DEP2PAREN = table.Column<string>(name: "DEP2_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP2NASC = table.Column<string>(name: "DEP2_NASC", type: "nvarchar(max)", nullable: true),
                    DEP2RENDA = table.Column<string>(name: "DEP2_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP3NOME = table.Column<string>(name: "DEP3_NOME", type: "nvarchar(max)", nullable: true),
                    DEP3PAREN = table.Column<string>(name: "DEP3_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP3NASC = table.Column<string>(name: "DEP3_NASC", type: "nvarchar(max)", nullable: true),
                    DEP3RENDA = table.Column<string>(name: "DEP3_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP4NOME = table.Column<string>(name: "DEP4_NOME", type: "nvarchar(max)", nullable: true),
                    DEP4PAREN = table.Column<string>(name: "DEP4_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP4NASC = table.Column<string>(name: "DEP4_NASC", type: "nvarchar(max)", nullable: true),
                    DEP4RENDA = table.Column<string>(name: "DEP4_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP5NOME = table.Column<string>(name: "DEP5_NOME", type: "nvarchar(max)", nullable: true),
                    DEP5PAREN = table.Column<string>(name: "DEP5_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP5NASC = table.Column<string>(name: "DEP5_NASC", type: "nvarchar(max)", nullable: true),
                    DEP5RENDA = table.Column<string>(name: "DEP5_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP6NOME = table.Column<string>(name: "DEP6_NOME", type: "nvarchar(max)", nullable: true),
                    DEP6PAREN = table.Column<string>(name: "DEP6_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP6NASC = table.Column<string>(name: "DEP6_NASC", type: "nvarchar(max)", nullable: true),
                    DEP6RENDA = table.Column<string>(name: "DEP6_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP7NOME = table.Column<string>(name: "DEP7_NOME", type: "nvarchar(max)", nullable: true),
                    DEP7PAREN = table.Column<string>(name: "DEP7_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP7NASC = table.Column<string>(name: "DEP7_NASC", type: "nvarchar(max)", nullable: true),
                    DEP7RENDA = table.Column<string>(name: "DEP7_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP8NOME = table.Column<string>(name: "DEP8_NOME", type: "nvarchar(max)", nullable: true),
                    DEP8PAREN = table.Column<string>(name: "DEP8_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP8NASC = table.Column<string>(name: "DEP8_NASC", type: "nvarchar(max)", nullable: true),
                    DEP8RENDA = table.Column<string>(name: "DEP8_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP9NOME = table.Column<string>(name: "DEP9_NOME", type: "nvarchar(max)", nullable: true),
                    DEP9PAREN = table.Column<string>(name: "DEP9_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP9NASC = table.Column<string>(name: "DEP9_NASC", type: "nvarchar(max)", nullable: true),
                    DEP9RENDA = table.Column<string>(name: "DEP9_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP10NOME = table.Column<string>(name: "DEP10_NOME", type: "nvarchar(max)", nullable: true),
                    DEP10PAREN = table.Column<string>(name: "DEP10_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP10NASC = table.Column<string>(name: "DEP10_NASC", type: "nvarchar(max)", nullable: true),
                    DEP10RENDA = table.Column<string>(name: "DEP10_RENDA", type: "nvarchar(max)", nullable: true),
                    DEP11NOME = table.Column<string>(name: "DEP11_NOME", type: "nvarchar(max)", nullable: true),
                    DEP11PAREN = table.Column<string>(name: "DEP11_PAREN", type: "nvarchar(max)", nullable: true),
                    DEP11NASC = table.Column<string>(name: "DEP11_NASC", type: "nvarchar(max)", nullable: true),
                    DEP11RENDA = table.Column<string>(name: "DEP11_RENDA", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CADASTRO", x => x.IDREGISTRO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CADASTRO");
        }
    }
}
