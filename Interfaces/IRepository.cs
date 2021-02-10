using System.Collections.Generic;

namespace Series.Interfaces
{
    public interface IRepository<Tipo>
    {
        List<Tipo> Lista();
        Tipo RetornaPorId(int id);        
        void Insere(Tipo entidade);        
        void Exclui(int id);        
        void Atualiza(int id, Tipo entidade);
        int ProximoId();
    }
    
}