using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace data
{
    public class datos
    {
        DataProductsEntities1 ob = new DataProductsEntities1();
        //public string met()
        //{
        //    Product[] s = ob.FAVV_BuscaNombrePorId1(2).ToArray<Product>();
        //    return s[0].Nombre;
        //}

        public void ag()
        {
            ob.JEVJ1_InsertaNuevoProducto(null, null, null, null, null, "Tenis"
                , "puma", "unos tenis", "son tenis...",
                89M, 90M, 60M, true, "tenis", DateTime.Now);
        }

        public prod BuscaId(int ent)
        {
            return ob.BuscaProductoPorID(ent).FirstOrDefault<Products>();
        }

        public Products Busca(string s)
        {
            return ob.BuscaProductoPorNombre(s).FirstOrDefault<Products>();
        }

        public void Eliminar(string id)
        {
            ob.JEVJ1_EliminaProductoPorID(int.Parse(id));
            ob.SaveChanges();
        }
    }
}
    

