using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Purchase
    {
        public int ID { get; set; }

        public double TotalPrice;

        public Usuario Usuario;
        public List<Produto> Produtos;

        public DateTime Created;

        public Purchase()
        {

        }

        public static Purchase FindByID()
        {
            return new Purchase();
        }

        public static Purchase FindByUserID(int id)
        {
            return new Purchase();
        }

        public static Purchase FindByUserID(Usuario user)
        {
            return new Purchase();
        }
    }
}
