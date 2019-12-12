using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using data;

namespace tienda
{
    public class information
    {


        public product datos(pro ob)
        {
            serial();
            product pr = new product();
            pr.Id = ob.Id;
            pr.IdType = ob.IdType;
            pr.IdColor = ob.IdColor;
            pr.IdBrand = ob.IdBrand;
            pr.IdProvider = ob.IdProvider;
            pr.IdCatalog = ob.IdCatalog;
            pr.Title = ob.Title;
            pr.Nombre = ob.Nombre;
            pr.Description = ob.Description;
            pr.Observations = ob.Observations;
            pr.PriceDistributor = ob.PriceDistributor;
            pr.PriceClient = ob.PriceClient;
            pr.PriceMember = ob.PriceMember;
            pr.IsEnable = ob.IsEnable;
            pr.Keywords = ob.Keywords;
            pr.DateUpdate = ob.DateUpdate;
            return pr;
        }
    }
    public class product
    {
        public int? Id { get; set; }
        public int? IdType { get; set; }
        public int? IdColor { get; set; }
        public int? IdBrand { get; set; }
        public int? IdProvider { get; set; }
        public int? IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public decimal? PriceDistributor { get; set; }
        public decimal? PriceClient { get; set; }
        public decimal? PriceMember { get; set; }
        public Boolean IsEnable { get; set; }
        public string Keywords { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
