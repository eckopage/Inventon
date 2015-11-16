
using System;

namespace InventonAplikacja.Repository.Services
{
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using Inventon.DAL.Entities;
    using Interfaces;

    public class ProductService: IProduct
    {
        /// <summary>
        /// Add procuct to datatabse.
        /// </summary>
        /// <param name="productModel">Product model</param>
        /// <returns>Returns quantity of added rows. Return -1 when model not defined</returns>
        public int Add(ProduktTable productModel)
        {
            var result = -1;
            if (productModel == null) return result;

            using (var context = new InventonDatabaseEntities())
            {
                productModel.ProduktDataDodania = DateTime.Now;
                context.ProduktTable.Add(productModel);
                result = context.SaveChanges();
            }

            return result;
        }

        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="id">Product id</param>
        public void Delete(int id)
        {
            using (var context = new InventonDatabaseEntities())
            {
                var foundProduct = Get(id);
                if (foundProduct == null) return;
                context.ProduktTable.Remove(foundProduct);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get specific product by id.
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Returns product model</returns>
        public ProduktTable Get(int id)
        {
            using (var context = new InventonDatabaseEntities())
            {
                return context.ProduktTable.Find(id);
            }
        }

        /// <summary>
        /// Edit produkt model
        /// </summary>
        /// <param name="produktModel">Produkt model</param>
        /// <returns>Returns quantity of updated rows. Return -1 when model not defined</returns>
        public int Edit(ProduktTable produktModel)
        {
            var result = -1;
            if (produktModel == null) return result;

            using (var context = new InventonDatabaseEntities())
            {
                context.Entry(produktModel).State = EntityState.Modified;
                result = context.SaveChanges();
            }

            return result;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>Returns list of products</returns>
        public IList<ProduktTable> GetAll()
        {
            IList<ProduktTable> result;
            using (var context = new InventonDatabaseEntities())
            {
                result = context.ProduktTable.ToList();
            }
            return result;
        }

    }
}