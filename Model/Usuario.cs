using System;
using System.Data.SqlClient;


namespace Model
{
    public class Usuario
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public char TypeUser { get; set; }

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

            string SQL = "INSERT INTO USERS(email, ecy_password, type_user, first_name) VALUES (@EMAIL,@PASS,@TYPE,@NAME)";
            SqlCommand Comando = new SqlCommand(SQL, BancoDeDados.Conexao);
            Comando.Parameters.AddWithValue("@EMAIL",this.Email);
            Comando.Parameters.AddWithValue("@PASS", this.Password);
            Comando.Parameters.AddWithValue("@TYPE", this.TypeUser);
            Comando.Parameters.AddWithValue("@NAME", this.Name);
            BancoDeDados.Conexao.Open();

            try
            {
                BancoDeDados.Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();

                while (render.Read())
                {

                    if (render.GetValue(2).ToString() == "a")
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
        }

        public static string Cadastrar(Usuario user)
        {
            string SQL = "INSERT INTO USERS(email, ecy_password, type_user, first_name) VALUES (@EMAIL,@PASS,@TYPE,@NAME)";
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
                    return "111";
                    //E-mail cadastrado com sucesso
                }

                else if (info > 1)
                {
                    BancoDeDados.Conexao.Close();
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

        
    }
}
