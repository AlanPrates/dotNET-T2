using System.Collections.Generic;
using TechAdvocacia.Core.Models;

namespace TechAdvocacia.Core.Services {
    public interface IAdvogadoService {
        IEnumerable<Advogado> GetAll();
        Advogado GetById(int id);
        Advogado Create(Advogado advogado);
        void Update(Advogado advogado);
        void Delete(int id);
    }
}
