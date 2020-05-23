using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Model
{
    public class Produto
    {
        public string Name;
        public int ID { get; set; }
        public double Price;
        public int Stock;
        public DateTime Created;

        public Produto()
        {
            this.Name = "";
            this.Price = 0;
            this.Stock = 0;
        }

        public Produto(Produto p)
        {
            this.ID = p.ID;
            this.Name = p.Name;
            this.Price = p.Price;
            this.Stock = p.Stock;
            this.Created = p.Created;
        }

        public Produto(int id, string name, double price, int stock, DateTime created)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Created = created;
        }

        public string Cadastrar()
        {
            string SQL = "INSERT INTO products(name, price, strock) VALUES (@NAME,@PRICE,@STOCK)";

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
            string SQL = "INSERT INTO products(name, price, strock) VALUES (@NAME,@PRICE,@STOCK)";

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
            string SQL = "INSERT INTO products(name, price, strock) VALUES (@NAME,@PRICE,@STOCK)";

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

            string SQL = "SELECT * FROM products;";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            try
            {
                BancoDeDados.Conexao.Open();
                Comando.CommandType = System.Data.CommandType.Text;
                SqlDataReader render = Comando.ExecuteReader();
                while (render.Read())
                {
                    var prod = new Produto();

                    prod.ID = render.GetInt32(0);
                    prod.Name = render.GetString(1);
                    prod.Price = double.Parse( render.GetValue(2).ToString() );
                    prod.Stock = render.GetInt32(3);
                    prod.Created = render.GetDateTime(5);

                    All.Add(prod);
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

        public static Produto[] Take(int take)
        {
            Produto[] Take = new Produto[take];

            string SQL = "SELECT TOP("+ take + ") products.ID,products.product_name,products.price,products.stock,products.created_at FROM products;";
            int index = 0;
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();
                while (render.Read())
                {
                    Take[index] = (new Produto(render.GetInt32(0), render.GetString(1), double.Parse(render.GetValue(2).ToString()), render.GetInt32(3), render.GetDateTime(4)));
                    index++;
                }
                BancoDeDados.Conexao.Close();
                return Take;
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return Take;
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

            string SQL = "SELECT products.ID,products.product_name,products.price,products.stock FROM products WHERE products.ID = @ID";
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
                    product.Price = double.Parse(render.GetValue(2).ToString());
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

        public static int GetStock(int id)
        {
            int stock = -1;

            string SQL = "SELECT products.stock FROM products WHERE ID = @ID;";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
            Comando.Parameters.AddWithValue("@ID", id);

            try
            {
                BancoDeDados.Conexao.Open();

                Comando.CommandType = System.Data.CommandType.Text;
                SqlDataReader render = Comando.ExecuteReader();



                while (render.Read())
                {
                    stock = render.GetInt32(0);
                }
                BancoDeDados.Conexao.Close();
                return stock;
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return stock;
                //000 - Erro inesperado.
            }

            finally
            {
                BancoDeDados.Conexao.Close();
            }
        }

        public static string SetStock(int id, int valor)
        {
            string SQL = "UPDATE products SET products.stock = @STOCK WHERE id = @ID;";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            Comando.Parameters.AddWithValue("@STOCK", valor);
            Comando.Parameters.AddWithValue("@ID", id);

            try
            {
                int info = Comando.ExecuteNonQuery();
                if (info > 0)
                {
                    return "300";
                    //Produto Atualizado.
                }

                else
                {
                    return "310";
                    //Produto não Atualizado
                }
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return "318";
                //318 - Erro ao Atualizar
            }
        }
    }
}
