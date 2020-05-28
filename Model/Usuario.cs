using System;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Model
{
    public class Usuario
    {
        public int ID
        {
            set;
            get;
        }

        /// <summary>
        /// Nome do Usuario
        /// </summary>
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Qual o tipo do Usuario
        /// P = Padrão | A = Administrador
        /// </summary>
        public char TypeUser { get; set; }
        public DateTime Created;

        public Usuario(string email, string password)
        {
            this.ID = -1;
            this.Email = email;
            this.Password = password;
        }

        public Usuario(string name, string email, string password)
        {
            this.ID = -1;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public Usuario(string name)
        {
            this.ID = -1;
            this.Name = name;
            this.Email = "";
            this.Password = "";
        }

        public Usuario()
        {
            this.ID = -1;
            this.Name = "Desconhecido";
            this.Email = "";
            this.Password = "";
        }

        public string Login()
        {

            string SQL = "SELECT USERS.ID, USERS.type_user  FROM USERS WHERE email = @EMAIL and ecy_password = @PASS";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
            Comando.Parameters.AddWithValue("@EMAIL", Email);
            Comando.Parameters.AddWithValue("@PASS", Password);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();
                while (render.Read())
                {

                    if (render.GetValue(1).ToString() == "a")
                    {
                        BancoDeDados.Conexao.Close();
                        return "101";
                        //110 - Usuario logado é um administrador
                    }
                    BancoDeDados.Conexao.Close();
                    return "100";
                    //200 - Usuario logado é padrão
                }
                BancoDeDados.Conexao.Close();
                return "010";
                //010 - Usuario não cadastrado

            }

            catch (Exception e)
            {
                BancoDeDados.Conexao.Close();
                return "000" + e;
                //000 - Erro inesperado.
            }

            finally
            {
                BancoDeDados.Conexao.Close();
            }
        }

        public static string Login(Usuario user)
        {

            string SQL = "SELECT USERS.ID, USERS.admi  FROM USERS WHERE email = @EMAIL and ecy_password = @PASS";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
            Comando.Parameters.AddWithValue("@EMAIL", user.Email);
            Comando.Parameters.AddWithValue("@PASS", user.Password);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();

                while (render.Read())
                {

                    if (render.GetValue(1).ToString() == "admi")
                    {
                        return "101";
                        //110 - Usuario logado é um administrador
                    }

                    return "100|" + render.GetValue(0).ToString();
                    //200 - Usuario logado é padrão
                }

                BancoDeDados.Conexao.Close();
                return "010";
                //010 - Usuario não cadastrado

            }

            catch (Exception e)
            {
                BancoDeDados.Conexao.Close();
                return "000" + e;
                //000 - Erro inesperado.
            }
        }

        public string Cadastrar()
        {

            string SQL = "INSERT INTO USERS(email, ecy_password, type_user, first_name, created_at) VALUES (@EMAIL,@PASS,@TYPE,@NAME,GETDATE())";
            var u = Usuario.Where("email = " + this.Email);

            if (u.ID < 0)
            {
                SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
                Comando.Parameters.AddWithValue("@EMAIL", this.Email);
                Comando.Parameters.AddWithValue("@PASS", this.Password);
                Comando.Parameters.AddWithValue("@TYPE", this.TypeUser);
                Comando.Parameters.AddWithValue("@NAME", this.Name);
                BancoDeDados.Conexao.Open();

                try
                {
                    int info = Comando.ExecuteNonQuery();
                    if (info > 0)
                    {
                        BancoDeDados.Conexao.Close();
                        Debug.WriteLine("111");
                        return "111";
                        //E-mail cadastrado com sucesso
                    }

                    else if (info > 1)
                    {
                        BancoDeDados.Conexao.Close();
                        Debug.WriteLine("100");
                        return "100";
                        //E-mail cadastrado
                    }


                    else
                    {
                        BancoDeDados.Conexao.Close();
                        return "001";
                        //001 - Ocorreu um erro e seu e-mail não foi cadastrado\nTente novamente mais tarde
                    }
                }

                catch (Exception)
                {
                    BancoDeDados.Conexao.Close();
                    return "018";
                    //118 - Erro caso já exista um email cadastrado com mesmo nome
                }
            }
            else
            {
                BancoDeDados.Conexao.Close();
                Debug.WriteLine("011");
                return "011";
                //E-mail já cadastrado
            }
        }

        public static string Cadastrar(Usuario user)
        {
            string SQL = "INSERT INTO USERS(email, ecy_password, type_user, first_name, created_at) VALUES (@EMAIL,@PASS,@TYPE,@NAME,GETDATE())";
            var u = Usuario.Where("email = " + user.Email);

            if (u.ID < 0)
            {
                SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
                Comando.Parameters.AddWithValue("@EMAIL", user.Email);
                Comando.Parameters.AddWithValue("@PASS", user.Password);
                Comando.Parameters.AddWithValue("@TYPE", user.TypeUser);
                Comando.Parameters.AddWithValue("@NAME", user.Name);
                BancoDeDados.Conexao.Open();

                try
                {
                    int info = Comando.ExecuteNonQuery();
                    if (info > 0)
                    {
                        BancoDeDados.Conexao.Close();
                        Debug.WriteLine("111");
                        return "111";
                        //E-mail cadastrado com sucesso
                    }

                    else if (info > 1)
                    {
                        BancoDeDados.Conexao.Close();
                        Debug.WriteLine("100");
                        return "100";
                        //E-mail cadastrado
                    }


                    else
                    {
                        BancoDeDados.Conexao.Close();
                        return "001";
                        //001 - Ocorreu um erro e seu e-mail não foi cadastrado\nTente novamente mais tarde
                    }
                }

                catch (Exception)
                {
                    BancoDeDados.Conexao.Close();
                    return "018";
                    //118 - Erro caso já exista um email cadastrado com mesmo nome
                }
            }

            else
            {
                BancoDeDados.Conexao.Close();
                Debug.WriteLine("011");
                return "011";
                //E-mail já cadastrado
            }
        }

        public static Usuario Find(int id)
        {
            Usuario user = new Usuario();
            string SQL = "SELECT users.first_name,users.email,users.type_user,users.created_at,users.id FROM users WHERE id=@ID;";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
            Comando.Parameters.AddWithValue("@ID", id);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();

                while (render.Read())
                {
                    user.Name = render.GetString(0);
                    user.Email = render.GetString(1);
                    user.TypeUser = char.Parse(render.GetString(2));
                    user.Created = render.GetDateTime(3);
                    user.ID = render.GetInt32(4);
                }

                BancoDeDados.Conexao.Close();
                //200 - Encontrado
                return user;
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return user;
                //000 - Erro inesperado.
            }

            finally
            {
                BancoDeDados.Conexao.Close();
            }
        }
        public static Usuario Where(string sql)
        {
            Usuario user = new Usuario();
            string SQL = "SELECT users.first_name,users.email,users.type_user,users.created_at,users.id FROM users WHERE ;" + sql;
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();

                while (render.Read())
                {
                    user.Name = render.GetString(0);
                    user.Email = render.GetString(1);
                    user.TypeUser = char.Parse(render.GetString(2));
                    user.Created = render.GetDateTime(3);
                    user.ID = render.GetInt32(4);
                }

                BancoDeDados.Conexao.Close();
                //200 - Encontrado
                return user;
            }

            catch (Exception)
            {
                BancoDeDados.Conexao.Close();
                return user;
                //000 - Erro inesperado.
            }

            finally
            {
                BancoDeDados.Conexao.Close();
            }
        }
    }
}
