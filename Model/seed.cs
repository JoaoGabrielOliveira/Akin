using System;

namespace Model
{
    public static class seed
    {
        public static void Main()
        {
            Usuario.Cadastrar(new Usuario("João", "j@gmail.com", "12345678"));
        }
    }
}
