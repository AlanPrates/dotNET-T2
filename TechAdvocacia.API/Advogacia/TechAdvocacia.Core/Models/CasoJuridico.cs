using System;
using System.Collections.Generic;

namespace TechAdvocacia.Core.Models {
    public class CasoJuridico {
        public int Id { get; set; }
        public DateTime AberturaData { get; set; }
        public float ProbabilidadeSucesso { get; set; }
        public List<Documento> Documentos { get; set; } = new List<Documento>();
        public List<Tuple<float, string>> Custos { get; set; } = new List<Tuple<float, string>>();
        public DateTime? EncerramentoData { get; set; }
        public List<Advogado> Advogados { get; set; } = new List<Advogado>();
        public Cliente Cliente { get; set; }
        public string Status { get; set; }
    }
}
