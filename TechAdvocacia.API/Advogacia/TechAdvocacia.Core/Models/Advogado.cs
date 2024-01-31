using System;

namespace TechAdvocacia.Core.Models {
    public class Advogado {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; } // Adicionado conforme solicitado
        public string CPF { get; set; }
        public string CNA { get; set; }

        // Assumindo a inclusão de outros campos que podem ser relevantes para um Advogado
        // Inclua ou remova campos conforme necessário para sua aplicação
        public string EstadoCivil { get; set; }
        public string Profissao { get; set; }
        // Exemplo: public string OAB { get; set; } // Se necessário
    }
}
