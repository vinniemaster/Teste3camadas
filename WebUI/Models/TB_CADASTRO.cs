using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebUI.Models
{
    public class UppercaseContractSolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToUpper();
        }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class TB_CADASTRO
    {
        [Key]
        [JsonPropertyName("ID_REGISTRO")]
        public Guid ID_REGISTRO { get; set; }
        [JsonPropertyName("NRO_INSCRICAO")]
        [DisplayName("Nº Inscriçao")]
        public int NRO_INSCRICAO { get; set; }
        [JsonPropertyName("DATA_INSCRICAO")]
        [DisplayName("Data")]
        public DateTime DATA_INSCRICAO { get; set; }
        [JsonPropertyName("NOME_TIT")]
        [DisplayName("Nome")]
        public string NOME_TIT { get; set; }
        [JsonPropertyName("NASC_TIT")]
        [DisplayName("Data de Nascimento")]
        public DateTime NASC_TIT { get; set; }
        [JsonPropertyName("RG_TIT")]
        [DisplayName("RG")]
        public string RG_TIT { get; set; }
        [JsonPropertyName("CPF_TIT")]
        [DisplayName("CPF")]
        public string CPF_TIT { get; set; }
        [JsonPropertyName("EST_CIVIL_TIT")]
        [DisplayName("Estado Civíl")]
        public string EST_CIVIL_TIT { get; set; }
        [JsonPropertyName("SEXO_TIT")]
        [DisplayName("Sexo")]
        public char SEXO_TIT { get; set; }
        [JsonPropertyName("NATURAL_TIT")]
        [DisplayName("Naturalidade")]
        public string NATURAL_TIT { get; set; }
        [JsonPropertyName("NESC_ESP_TIT_DESCRICAO")]
        [DisplayName("Descreva:")]
        public string? NESC_ESP_TIT_DESCRICAO { get; set; }
        [JsonPropertyName("NOME_MAE")]
        [DisplayName("Nome da Mãe")]
        public string NOME_MAE { get; set; }
        [JsonPropertyName("ENDERECO")]
        [DisplayName("Endereço")]
        public string ENDERECO { get; set; }
        [JsonPropertyName("ENDERECO_NRO")]
        [DisplayName("Nro")]
        public string ENDERECO_NRO { get; set; }
        [JsonPropertyName("ENDERECO_COMP")]
        [DisplayName("Complemento")]
        public string ENDERECO_COMP { get; set; }
        [JsonPropertyName("BAIRRO")]
        [DisplayName("Bairro")]
        public string BAIRRO { get; set; }
        [JsonPropertyName("CEP")]
        [DisplayName("CEP")]
        public string CEP { get; set; }
        [JsonPropertyName("MUNICIPIO")]
        [DisplayName("Município")]
        public string MUNICIPIO { get; set; }
        [JsonPropertyName("TELEFONE_RES")]
        [DisplayName("Telefone Residencial")]
        public string? TELEFONE_RES { get; set; }
        [JsonPropertyName("TELEFONE_CEL")]
        [DisplayName("Telefone Celular")]
        public string TELEFONE_CEL { get; set; }
        [JsonPropertyName("EMPRESA_TIT")]
        [DisplayName("Nome da Empresa")]
        public string EMPRESA_TIT { get; set; }
        [JsonPropertyName("PROF_TIT")]
        [DisplayName("Profissão")]
        public string PROF_TIT { get; set; }
        [JsonPropertyName("RENDA_TIT")]
        [DisplayName("Renda Familiar")]
        public string RENDA_TIT { get; set; }
        [JsonPropertyName("END_COMERCIAL_TIT")]
        [DisplayName("Endereço Comercial")]
        public string END_COMERCIAL_TIT { get; set; }
        [JsonPropertyName("NRO_COMERCIAL_TIT")]
        [DisplayName("Nro")]
        public string NRO_COMERCIAL_TIT { get; set; }
        [JsonPropertyName("BAIRRO_COMERCIAL_TIT")]
        [DisplayName("Bairro")]
        public string BAIRRO_COMERCIAL_TIT { get; set; }
        [JsonPropertyName("CEP_COMERCIAL_TIT")]
        [DisplayName("CEP")]
        public string CEP_COMERCIAL_TIT { get; set; }
        [JsonPropertyName("MUNI_COMERCIAL_TIT")]
        [DisplayName("Município")]
        public string MUNI_COMERCIAL_TIT { get; set; }
        [JsonPropertyName("NOME_CON")]
        [DisplayName("Nome")]
        public string? NOME_CON { get; set; }
        [JsonPropertyName("NASC_CON")]
        [DisplayName("Data de Nascimento")]
        public DateTime? NASC_CON { get; set; }
        [JsonPropertyName("RG_CON")]
        [DisplayName("RG")]
        public string? RG_CON { get; set; }
        [JsonPropertyName("CPF_CON")]
        [DisplayName("CPF")]
        public string? CPF_CON { get; set; }
        [JsonPropertyName("EST_CIVIL_CON")]
        [DisplayName("Estado Civíl")]
        public string? EST_CIVIL_CON { get; set; }
        [JsonPropertyName("SEXO_CON")]
        [DisplayName("Sexo")]
        public char? SEXO_CON { get; set; }
        [JsonPropertyName("NATURAL_CON")]
        [DisplayName("Naturalidade")]
        public string? NATURAL_CON { get; set; }
        [JsonPropertyName("NESC_ESP_CON_DESCRICAO")]
        [DisplayName("Descreva:")]
        public string? NESC_ESP_CON_DESCRICAO { get; set; }
        [JsonPropertyName("EMPRESA_CON")]
        [DisplayName("Nome da Empresa")]
        public string? EMPRESA_CON { get; set; }
        [JsonPropertyName("PROF_CON")]
        [DisplayName("Profissão")]
        public string? PROF_CON { get; set; }
        [JsonPropertyName("RENDA_CON")]
        [DisplayName("Renda Familiar")]
        public string? RENDA_CON { get; set; }
        [JsonPropertyName("END_COMERCIAL_CON")]
        [DisplayName("Endereço Comercial")]
        public string? END_COMERCIAL_CON { get; set; }
        [JsonPropertyName("NRO_COMERCIAL_CON")]
        [DisplayName("Nro")]
        public string? NRO_COMERCIAL_CON { get; set; }
        [JsonPropertyName("BAIRRO_COMERCIAL_CON")]
        [DisplayName("Bairro")]
        public string? BAIRRO_COMERCIAL_CON { get; set; }
        [JsonPropertyName("CEP_COMERCIAL_CON")]
        [DisplayName("CEP")]
        public string? CEP_COMERCIAL_CON { get; set; }
        [JsonPropertyName("MUNI_COMERCIAL_CON")]
        [DisplayName("Município")]
        public string? MUNI_COMERCIAL_CON { get; set; }
        [JsonPropertyName("DEP1_NOME")]
        [DisplayName("Nome")]
        public string? DEP1_NOME { get; set; }
        [JsonPropertyName("DEP1_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP1_PAREN { get; set; }
        [JsonPropertyName("DEP1_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP1_NASC { get; set; }
        [JsonPropertyName("DEP1_RENDA")]
        [DisplayName("Renda")]
        public string? DEP1_RENDA { get; set; }
        [JsonPropertyName("DEP2_NOME")]
        [DisplayName("Nome")]
        public string? DEP2_NOME { get; set; }
        [JsonPropertyName("DEP2_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP2_PAREN { get; set; }
        [JsonPropertyName("DEP2_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP2_NASC { get; set; }
        [JsonPropertyName("DEP2_RENDA")]
        [DisplayName("Renda")]
        public string? DEP2_RENDA { get; set; }
        [JsonPropertyName("DEP3_NOME")]
        [DisplayName("Nome")]
        public string? DEP3_NOME { get; set; }
        [JsonPropertyName("DEP3_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP3_PAREN { get; set; }
        [JsonPropertyName("DEP3_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP3_NASC { get; set; }
        [JsonPropertyName("DEP3_RENDA")]
        [DisplayName("Renda")]
        public string? DEP3_RENDA { get; set; }
        [JsonPropertyName("DEP4_NOME")]
        [DisplayName("Nome")]
        public string? DEP4_NOME { get; set; }
        [JsonPropertyName("DEP4_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP4_PAREN { get; set; }
        [JsonPropertyName("DEP4_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP4_NASC { get; set; }
        [JsonPropertyName("DEP4_RENDA")]
        [DisplayName("Renda")]
        public string? DEP4_RENDA { get; set; }
        [JsonPropertyName("DEP5_NOME")]
        [DisplayName("Nome")]
        public string? DEP5_NOME { get; set; }
        [JsonPropertyName("DEP5_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP5_PAREN { get; set; }
        [JsonPropertyName("DEP5_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP5_NASC { get; set; }
        [JsonPropertyName("DEP5_RENDA")]
        [DisplayName("Renda")]
        public string? DEP5_RENDA { get; set; }
        [JsonPropertyName("DEP6_NOME")]
        [DisplayName("Nome")]
        public string? DEP6_NOME { get; set; }
        [JsonPropertyName("DEP6_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP6_PAREN { get; set; }
        [JsonPropertyName("DEP6_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP6_NASC { get; set; }
        [JsonPropertyName("DEP6_RENDA")]
        [DisplayName("Renda")]
        public string? DEP6_RENDA { get; set; }
        [JsonPropertyName("DEP7_NOME")]
        [DisplayName("Nome")]
        public string? DEP7_NOME { get; set; }
        [JsonPropertyName("DEP7_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP7_PAREN { get; set; }
        [JsonPropertyName("DEP7_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP7_NASC { get; set; }
        [JsonPropertyName("DEP7_RENDA")]
        [DisplayName("Renda")]
        public string? DEP7_RENDA { get; set; }
        [JsonPropertyName("DEP8_NOME")]
        [DisplayName("Nome")]
        public string? DEP8_NOME { get; set; }
        [JsonPropertyName("DEP8_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP8_PAREN { get; set; }
        [JsonPropertyName("DEP8_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP8_NASC { get; set; }
        [JsonPropertyName("DEP8_RENDA")]
        [DisplayName("Renda")]
        public string? DEP8_RENDA { get; set; }
        [JsonPropertyName("DEP9_NOME")]
        [DisplayName("Nome")]
        public string? DEP9_NOME { get; set; }
        [JsonPropertyName("DEP9_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP9_PAREN { get; set; }
        [JsonPropertyName("DEP9_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP9_NASC { get; set; }
        [JsonPropertyName("DEP9_RENDA")]
        [DisplayName("Renda")]
        public string? DEP9_RENDA { get; set; }
        [JsonPropertyName("DEP10_NOME")]
        [DisplayName("Nome")]
        public string? DEP10_NOME { get; set; }
        [JsonPropertyName("DEP10_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP10_PAREN { get; set; }
        [JsonPropertyName("DEP10_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP10_NASC { get; set; }
        [JsonPropertyName("DEP10_RENDA")]
        [DisplayName("Renda")]
        public string? DEP10_RENDA { get; set; }
        [JsonPropertyName("DEP11_NOME")]
        [DisplayName("Nome")]
        public string? DEP11_NOME { get; set; }
        [JsonPropertyName("DEP11_PAREN")]
        [DisplayName("Parentesco")]
        public string? DEP11_PAREN { get; set; }
        [JsonPropertyName("DEP11_NASC")]
        [DisplayName("Data de Nascimento")]
        public string? DEP11_NASC { get; set; }
        [JsonPropertyName("DEP11_RENDA")]
        [DisplayName("Renda")]
        public string? DEP11_RENDA { get; set; }
    }
}



