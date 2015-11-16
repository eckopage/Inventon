
namespace InventonAplikacja.Repository.Interfaces
{
    using System.Collections.Generic;
    using Inventon.DAL.Entities;

    public interface IProduct
    {
        /// <summary>
        /// Add procuct to datatabse.
        /// </summary>
        /// <param name="productModel">Product model</param>
        /// <returns>Returns quantity of added rows. Return -1 when model not defined</returns>
        int Add(ProduktTable productModel);

        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="id">Product id</param>
        void Delete(int id);

        /// <summary>
        /// Get specific product by id.
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Returns product model</returns>
        ProduktTable Get(int id);

        /// <summary>
        /// Edit produkt model
        /// </summary>
        /// <param name="produktModel">Produkt model</param>
        /// <returns>Returns quantity of updated rows. Return -1 when model not defined</returns>
        int Edit(ProduktTable produktModel);

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>Returns list of products</returns>
        IList<ProduktTable> GetAll();
    }
}
