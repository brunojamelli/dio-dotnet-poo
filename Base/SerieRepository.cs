using System;
using System.Collections.Generic;
using dio_dotnet_poo.Interfaces;

namespace dio_dotnet_poo
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSeries = new List<Serie>();
        public void delete(int id)
        {
            listSeries[id].Excluir();
        }

        public Serie getById(int id)
        {
            return listSeries[id];
        }

        public void insert(Serie entity)
        {
            listSeries.Add(entity);
        }

        public List<Serie> listAll()
        {
            return listSeries;
        }

        public int nextId()
        {
            return listSeries.Count;
        }

        public void update(int id, Serie entity)
        {
            listSeries[id] = entity;
        }
    }
}