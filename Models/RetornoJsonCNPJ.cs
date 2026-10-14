using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERPW.Web.Models
{
    public class Empresa
    {
        [JsonPropertyName("razao_social")]
        public string? RazaoSocial { get; set; }

        [JsonPropertyName("cnpj_raiz")]
        public string? CnpjRaiz { get; set; }

        [JsonPropertyName("capital_social")]
        public string? CapitalSocial { get; set; }

        [JsonPropertyName("porte")]
        public Porte? Porte { get; set; }

        [JsonPropertyName("natureza_juridica")]
        public NaturezaJuridica? NaturezaJuridica { get; set; }

        [JsonPropertyName("estabelecimento")]
        public Estabelecimento? Estabelecimento { get; set; }
    }

    public class Porte
    {
        [JsonPropertyName("descricao")]
        public string? Descricao { get; set; }
    }

    public class NaturezaJuridica
    {
        [JsonPropertyName("descricao")]
        public string? Descricao { get; set; }
    }

    public class Estabelecimento
    {
        [JsonPropertyName("cnpj")]
        public string? CNPJ { get; set; }

        [JsonPropertyName("nome_fantasia")]
        public string? NomeFantasia { get; set; }

        [JsonPropertyName("situacao_cadastral")]
        public string? SituacaoCadastral { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string? Numero { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("cep")]
        public string? CEP { get; set; }

        [JsonPropertyName("cidade")]
        public Cidade? Cidade { get; set; }

        [JsonPropertyName("estado")]
        public Estado? Estado { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("telefone1")]
        public string? Telefone1 { get; set; }

        [JsonPropertyName("atividade_principal")]
        public Atividade? AtividadePrincipal { get; set; }

        [JsonPropertyName("inscricoes_estaduais")]
        public List<InscricaoEstadual>? InscricoesEstaduais { get; set; }
    }

    public class Cidade
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
    }

    public class Estado
    {
        [JsonPropertyName("sigla")]
        public string? Sigla { get; set; }
    }

    public class Atividade
    {
        [JsonPropertyName("descricao")]
        public string? Descricao { get; set; }
    }

    public class InscricaoEstadual
    {
        [JsonPropertyName("inscricao_estadual")]
        public string? Numero { get; set; }

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; }

        [JsonPropertyName("estado")]
        public Estado? Estado { get; set; }
    }
}
