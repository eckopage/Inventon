using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventon.DAL.Entities;
using InventonAplikacja.Repository.Interfaces;

namespace InventonAplikacja.Repository.Services
{
    public class CategoryService:ICategory
    {
        public IList<KategoriaTable> GetAllCategory()
        {
            IList<KategoriaTable> result;
            using (var context = new InventonDatabaseEntities())
            {
                result = context.KategoriaTable.ToList();
            }
            return result;
        }
        
    }
}