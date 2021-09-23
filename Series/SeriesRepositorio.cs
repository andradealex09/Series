using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series.Interface;

namespace Series
{
    public class SeriesRepositorio : IRepositorio<Series>
    {

        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int id, Series objeto)
        {
            listaSeries[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSeries[id].excluir();
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}
