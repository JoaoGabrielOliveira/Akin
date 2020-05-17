using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Model
{
    class Produto
    {
        public string Name;
        public int ID { get; set; }
        public decimal Price;
        public int Stock;
        public DateTime Created;

        public Produto()
        {
            this.Name = "";
            this.Price = 0;
            this.Stock = 0;
        }

        public Produto(string name, decimal price, int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public Produto(int id, string name, decimal price, int stock, DateTime created)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public string Cadastrar()
        {
            string SQL = "INSERT INTO USERS(name, price, strock) VALUES (@NAME,@PRICE,@STOCK)";

            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            Comando.Parameters.AddWithValue("@NAME", this.Name);
            Comando.Parameters.AddWithValue("@PRICE", this.Price);
            Comando.Parameters.AddWithValue("@STOCK", this.Stock);
            BancoDeDados.Conexao.Open();

            try
            {
                int info = Comando.ExecuteNonQuery();
                if (info > 0)
                {
                    return "100";
                    //Produto cadastrado.
                }

                else
                {
                    return "010";
                    //Produto não cadastrado
                }
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return "018";
                //118 - Erro caso já exista um Produto cadastrado com mesmo nome
            }
        }

        public static string Cadastrar(Produto product)
        {
            string SQL = "INSERT INTO USERS(name, price, strock) VALUES (@NAME,@PRICE,@STOCK)";

            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            Comando.Parameters.AddWithValue("@NAME", product.Name);
            Comando.Parameters.AddWithValue("@PRICE", product.Price);
            Comando.Parameters.AddWithValue("@STOCK", product.Stock);
            BancoDeDados.Conexao.Open();

            try
            {
                int info = Comando.ExecuteNonQuery();
                if (info > 0)
                {
                    return "100";
                    //Produto cadastrado.
                }

                else
                {
                    return "010";
                    //Produto não cadastrado
                }
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return "018";
                //118 - Erro caso já exista um Produto cadastrado com mesmo nome
            }
        }

        public static string Cadastrar(Produto[] product)
        {
            string SQL = "INSERT INTO USERS(name, price, strock) VALUES (@NAME,@PRICE,@STOCK)";

            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            int info = 0;

            for (int i=0;i< product.Length;i++)
            {
                Comando.Parameters.AddWithValue("@NAME", product[i].Name);
                Comando.Parameters.AddWithValue("@PRICE", product[i].Price);
                Comando.Parameters.AddWithValue("@STOCK", product[i].Stock);

                BancoDeDados.Conexao.Open();

                try
                {
                    info = Comando.ExecuteNonQuery();
                }

                catch (Exception)
                {
                    BancoDeDados.Conexao.Close();
                    return "018|" + product[i].ID + "|" + product[i].Name;
                    //118 - Erro caso já exista um Produto cadastrado com mesmo nome
                }
            }

            if (info > 0)
            {
                return "100";
                //Produto cadastrado.
            }

            else
            {
                return "010";
                //Produtos não cadastrado
            }
        }

        public static List<Produto> All()
        {
            List<Produto> All = new List<Produto>();

            string SQL = "SELECT products.ID,products.product_name,products.price,products.stock,products.created_at FROM USERS;";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();
                while (render.Read())
                {
                    All.Add(new Produto(render.GetInt32(0), render.GetString(1), render.GetDecimal(2), render.GetInt32(3), render.GetDateTime(4)));
                }
                BancoDeDados.Conexao.Close();
                return All;
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return All;
                //000 - Erro inesperado.
            }

            finally
            {
                BancoDeDados.Conexao.Close();
            }
        }

        public static Produto Find(int id)
        {
            Produto product = new Produto();

            string SQL = "SELECT products.ID,products.product_name,products.price,products.stock FROM USERS WHERE products.ID = @ID";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
            Comando.Parameters.AddWithValue("@ID", id);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();

                while (render.Read())
                {
                    product.ID = render.GetInt32(0);
                    product.Name = render.GetString(1);
                    product.Price = render.GetDecimal(2);
                    product.Stock = render.GetInt32(3);
                }

                BancoDeDados.Conexao.Close();
                //200 - Encontrado
                return product;
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return product;
                //000 - Erro inesperado.
            }

            finally
            {
                BancoDeDados.Conexao.Close();
            }
        }
    }
}
