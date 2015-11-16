using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventon.DAL.Entities;

namespace InventonAplikacja.Repository.Interfaces
{
    public interface ICategory
    {
        IList<KategoriaTable> GetAllCategory();
    }
}
