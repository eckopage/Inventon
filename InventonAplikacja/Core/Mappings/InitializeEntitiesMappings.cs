using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using InventonAplikacja.Models;
using Inventon.DAL.Entities;
using InventonAplikacja.Core.Extension;

namespace InventonAplikacja.Core.Mappings
{
    public partial class MappingsDefinition
    {
        public static void InitializeEntitiesMappings()
        {
            Mapper.CreateMap<ProductModel, ProduktTable>().IgnoreAllNonExisting();
            Mapper.CreateMap<ProduktTable, ProductModel>().IgnoreAllNonExisting();

            Mapper.CreateMap<ProducerModel, ProducentTable>().IgnoreAllNonExisting();
            Mapper.CreateMap<ProducentTable, ProducerModel>().IgnoreAllNonExisting();

            Mapper.CreateMap<CategoryModel, KategoriaTable>().IgnoreAllNonExisting();
            Mapper.CreateMap<KategoriaTable, CategoryModel>().IgnoreAllNonExisting();

            Mapper.CreateMap<OrderModel, ZamowienieTable>().IgnoreAllNonExisting();
            Mapper.CreateMap<ZamowienieTable, OrderModel>().IgnoreAllNonExisting();

            Mapper.CreateMap<ProductOrderModel, ProduktZamowienieTable>().IgnoreAllNonExisting();
            Mapper.CreateMap<ProduktZamowienieTable, ProductOrderModel>().IgnoreAllNonExisting();

            Mapper.CreateMap<StatusModel, StatusZamowieniaTable>().IgnoreAllNonExisting();
            Mapper.CreateMap<StatusZamowieniaTable, StatusModel>().IgnoreAllNonExisting();
        }
    }
}