using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioDirectivo
    {
        IEnumerable<Directivo> GetAllDirectivo();
        Directivo AddDirectivo(Directivo directivo);
        Directivo UpdateDirectivo(Directivo directivo);
        void DeleteDirectivo(int id);
        Directivo GetDirectivo(int id);

    }
}