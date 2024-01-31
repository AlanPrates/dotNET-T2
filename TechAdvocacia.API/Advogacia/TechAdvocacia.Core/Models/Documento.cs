using System;

namespace TechAdvocacia.Core.Models {
    public class Documento {
        public int Id { get; set; }
        public DateTime DataHoraModificacao { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
