using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventon.DAL.Entities;
using InventonAplikacja.Repository.Interfaces;

namespace InventonAplikacja.Repository.Services
{
    public class ProducentService:IProducent
    {
        public IList<ProducentTable> GetAllProducents()
        {
            IList<ProducentTable> result;
            using (var context = new InventonDatabaseEntities())
            {
                result = context.ProducentTable.OrderBy(x => x.ProducentNazwa).ToList();
            }
            return result;
        }
    }
}