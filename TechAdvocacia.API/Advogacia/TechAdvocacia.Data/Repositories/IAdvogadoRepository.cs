using System.Collections.Generic;
using TechAdvocacia.Core.Models;

namespace TechAdvocacia.Data.Repositories {
    public interface IAdvogadoRepository {
        IEnumerable<Advogado> GetAll();
        Advogado GetById(int id);
        void Add(Advogado advogado);
        void Update(Advogado advogado);
        void Delete(int id);
    }
}
