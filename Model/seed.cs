using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class seed
    {
        public static void Main()
        {
            Usuario.Cadastrar(new Usuario("João", "j@gmail.com", "12345678"));

        }
    }
}
