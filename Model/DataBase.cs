using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataBase
    {
        public SqlConnection connectionDB()
        {
            string ConnectionString = "Server = localhost; Database=RESTAURANTE;Trusted_Connection=True";
            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            Console.WriteLine("Se abrio la conexion desde la capa de acceso a datos");
            return conexion;
        }

        public void disconnectDB(SqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se cerro la conexion con el Servidor de Base de Datos");
        }


        //Datos de Comida----------------------------------------------------------------------------------
        public void insert_food(List<Food> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = connectionDB();
                    String cadenaconex = "INSERT INTO COMIDA" +
                        "(CODIGO, NOMBRE_COMIDA, PRECIO, OBSERVACION, ESTADO)" +
                        "VALUES(@codigo, @nombre_com, @precio, @observacion, @estado)";
                    SqlCommand comand = new SqlCommand(cadenaconex, conexion);
                    comand.Parameters.AddWithValue("@codigo", lst[0].Code);
                    comand.Parameters.AddWithValue("@nombre_com", lst[0].FoodName);
                    comand.Parameters.AddWithValue("@precio", lst[0].Price);
                    comand.Parameters.AddWithValue("@observacion", lst[0].Observation);
                    comand.Parameters.AddWithValue("@estado", lst[0].State);

                    int t = Convert.ToInt32(comand.ExecuteNonQuery());

                    disconnectDB(conexion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }

        public List<Food> list_food()
        {
            List<Food> lstFood = new List<Food>();

            SqlConnection conexion = connectionDB();
            String cadenaconec = "SELECT CODIGO, NOMBRE_COMIDA, PRECIO, OBSERVACION, ESTADO from COMIDA";
            SqlCommand comando = new SqlCommand(cadenaconec, conexion);
            SqlDataReader food = comando.ExecuteReader();
            while (food.Read())
            {
                int code = int.Parse(food["CODIGO"].ToString());
                string foodName = food["NOMBRE_COMIDA"].ToString();
                double price = double.Parse(food["PRECIO"].ToString());
                string observation = food["OBSERVACION"].ToString();
                bool state = bool.Parse(food["ESTADO"].ToString());
                Food temp = new Food(code, foodName, price, observation, state);

                lstFood.Add(temp);
            }
            disconnectDB(conexion);
            return lstFood;
        }

        public string delete_foof(string id)
        {
            string msj = null;
            try
            {
                SqlConnection conexion = connectionDB();
                String delete = "DELETE COMIDA  WHERE CODIGO = @CODIGO";
                SqlCommand comando = new SqlCommand(delete, conexion);

                comando.Parameters.AddWithValue("CODIGO", id);

                int resultado = comando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    msj = "Registro Eliminado";
                }
                else
                {
                    msj = "Registro no se pudo eliminar";
                }
                disconnectDB(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                msj = "No se encontro el registo";
            }

            return msj;
        }

        public List<Food> buscar_comida_x_codigo(string codigo)
        {
            List<Food> lstComida = new List<Food>();

            SqlConnection conexion = connectionDB();
            String cadena = "SELECT CODIGO, NOMBRE_COMIDA, PRECIO, OBSERVACION, ESTADO from COMIDA WHERE codigo = " + codigo;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader food = comando.ExecuteReader();
            while (food.Read())
            {

                int code = int.Parse(food["CODIGO"].ToString());
                string foodName = food["NOMBRE_COMIDA"].ToString();
                double price = double.Parse(food["PRECIO"].ToString());
                string observation = food["OBSERVACION"].ToString();
                bool state = bool.Parse(food["ESTADO"].ToString());
                Food temp = new Food(code, foodName, price, observation, state);


                lstComida.Add(temp);
            }
            disconnectDB(conexion);
            return lstComida;
        }

        public void update(List<Food> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = connectionDB();
                    String cadenaconex = "UPDATE COMIDA SET NOMBRE_COMIDA=@nombre_com, " +
                        "PRECIO=@precio, OBSERVACION=@observacion, ESTADO=@estado WHERE CODIGO=@codigo";
                    SqlCommand comand = new SqlCommand(cadenaconex, conexion);
                    comand.Parameters.AddWithValue("@codigo", lst[0].Code);
                    comand.Parameters.AddWithValue("@nombre_com", lst[0].FoodName);
                    comand.Parameters.AddWithValue("@precio", lst[0].Price);
                    comand.Parameters.AddWithValue("@observacion", lst[0].Observation);
                    comand.Parameters.AddWithValue("@estado", lst[0].State);

                    int t = Convert.ToInt32(comand.ExecuteNonQuery());

                    disconnectDB(conexion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }

        //Datos Ordenes----------------------------------------------------------------------------------
        public void insert_order(List<Order> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = connectionDB();
                    String cadenaconex = "INSERT INTO ORDEN" +
                        "(ORDEN_COMPLETA, CLIENTE, MESA, TOTAL_PAGAR)" +
                        "VALUES(@orden, @cliente, @mesa, @total)";
                    SqlCommand comand = new SqlCommand(cadenaconex, conexion);
                    comand.Parameters.AddWithValue("@orden", lst[0].Comorder);
                    comand.Parameters.AddWithValue("@cliente", lst[0].Client);
                    comand.Parameters.AddWithValue("@mesa", lst[0].Table);
                    comand.Parameters.AddWithValue("@total", lst[0].TotPay);

                    int t = Convert.ToInt32(comand.ExecuteNonQuery());

                    disconnectDB(conexion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }

        public List<Order> list_order()
        {
            List<Order> lstOrder = new List<Order>();

            SqlConnection conexion = connectionDB();
            String cadenaconec = "SELECT ORDEN_COMPLETA, CLIENTE, MESA, TOTAL_PAGAR from ORDEN";
            SqlCommand comando = new SqlCommand(cadenaconec, conexion);
            SqlDataReader order = comando.ExecuteReader();
            while (order.Read())
            {
                string orden_com = order["ORDEN_COMPLETA"].ToString();
                string cliente = order["CLIENTE"].ToString();
                int table = int.Parse(order["MESA"].ToString());
                double totalPay = double.Parse(order["TOTAL_PAGAR"].ToString());
                Order temp = new Order(orden_com, cliente, table, totalPay);

                lstOrder.Add(temp);
            }
            disconnectDB(conexion);
            return lstOrder;
        }

        public string delete_order(string mesa)
        {
            string msj = null;
            try
            {
                SqlConnection conexion = connectionDB();
                String delete = "DELETE ORDEN  WHERE MESA = @MESA";
                SqlCommand comando = new SqlCommand(delete, conexion);

                comando.Parameters.AddWithValue("MESA", mesa);

                int resultado = comando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    msj = "Registro Eliminado";
                }
                else
                {
                    msj = "Registro no se pudo eliminar";
                }
                disconnectDB(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                msj = "No se encontro el registo";
            }

            return msj;
        }


        //Datos Usuarios----------------------------------------------------------------------------------
        public void insert_user(List<User> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = connectionDB();
                    String cadenaconex = "INSERT INTO USUARIO" +
                        "(CEDULA, NOMBRE, APELLIDO, TELEFONO, CORREO, CIUDAD, DIRECCION, CONTRASEÑA)" +
                        "VALUES(@cedula, @nombre, @apellido, @telefono, @correo, @ciudad, @direccion, @contraseña)";
                    SqlCommand comand = new SqlCommand(cadenaconex, conexion);
                    comand.Parameters.AddWithValue("@cedula", lst[0].Ci);
                    comand.Parameters.AddWithValue("@nombre", lst[0].Name);
                    comand.Parameters.AddWithValue("@apellido", lst[0].LastName);
                    comand.Parameters.AddWithValue("@telefono", lst[0].Phone);
                    comand.Parameters.AddWithValue("@correo", lst[0].Email);
                    comand.Parameters.AddWithValue("@ciudad", lst[0].City);
                    comand.Parameters.AddWithValue("@direccion", lst[0].Direction);
                    comand.Parameters.AddWithValue("@contraseña", lst[0].Password);

                    int t = Convert.ToInt32(comand.ExecuteNonQuery());

                    disconnectDB(conexion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }

        public List<User> list_user()
        {
            List<User> lstUser = new List<User>();

            SqlConnection conexion = connectionDB();
            String cadenaconec = "SELECT CEDULA, NOMBRE, APELLIDO, TELEFONO, CORREO, CIUDAD, DIRECCION, CONTRASEÑA from USUARIO";
            SqlCommand comando = new SqlCommand(cadenaconec, conexion);
            SqlDataReader user = comando.ExecuteReader();
            while (user.Read())
            {
                string cedula = user["CEDULA"].ToString();
                string nombre = user["NOMBRE"].ToString();
                string apelldio = user["APELLIDO"].ToString();
                string telefono = user["TELEFONO"].ToString();
                string correo = user["CORREO"].ToString();
                string ciudad = user["CIUDAD"].ToString();
                string direccion = user["DIRECCION"].ToString();
                string contraseña = user["CONTRASEÑA"].ToString();
                User temp = new User(cedula, nombre, apelldio, telefono, correo, ciudad, direccion, contraseña);

                lstUser.Add(temp);
            }
            disconnectDB(conexion);
            return lstUser;
        }
        public void update_User(List<User> lst)
        {
           try
           {
                if (lst != null)
                {
                    SqlConnection conexion = connectionDB();
                    String cadenauser = "UPDATE USUARIO SET NOMBRE=@nombre, APELLIDO=@apellido," +
                        "TELEFONO=@telefono, CORREO=@correo, CIUDAD=@ciudad, DIRECCION=@direccion," +
                        "CONTRASEÑA=@contraseña WHERE CEDULA=@cedula";
                    SqlCommand comand = new SqlCommand(cadenauser, conexion);
                    comand.Parameters.AddWithValue("@cedula", lst[0].Ci);
                    comand.Parameters.AddWithValue("@nombre", lst[0].Name);
                    comand.Parameters.AddWithValue("@apellido", lst[0].LastName);
                    comand.Parameters.AddWithValue("@telefono", lst[0].Phone);
                    comand.Parameters.AddWithValue("@correo", lst[0].Email);
                    comand.Parameters.AddWithValue("@ciudad", lst[0].City);
                    comand.Parameters.AddWithValue("@direccion", lst[0].Direction);
                    comand.Parameters.AddWithValue("@contraseña", lst[0].Password);

                    int t = Convert.ToInt32(comand.ExecuteNonQuery());

                    disconnectDB(conexion);



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar datos", ex);
            }
        }


        //Datos Reservacion----------------------------------------------------------------------------------
        public void insert_reservation(List<Reservation> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = connectionDB();
                    String cadenaconex = "INSERT INTO RESERVACION" +
                        "(NOMBRE, FECHA_HORA, NUMERO_PERSONAS, UBICACION, SUGERENCIA)" +
                        "VALUES(@nombre, @fecha, @numero_per, @ubicacion, @sugerencia)";
                    SqlCommand comand = new SqlCommand(cadenaconex, conexion);
                    comand.Parameters.AddWithValue("@nombre", lst[0].Name);
                    comand.Parameters.AddWithValue("@fecha", lst[0].DateandTime);
                    comand.Parameters.AddWithValue("@numero_per", lst[0].People);
                    comand.Parameters.AddWithValue("@ubicacion", lst[0].Location);
                    comand.Parameters.AddWithValue("@sugerencia", lst[0].Suggestion);

                    int t = Convert.ToInt32(comand.ExecuteNonQuery());

                    disconnectDB(conexion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }
        }


        public List<Reservation> list_reservation()
        {
            List<Reservation> lstReser = new List<Reservation>();

            SqlConnection conexion = connectionDB();
            String cadenaconec = "SELECT NOMBRE, FECHA_HORA, NUMERO_PERSONAS, UBICACION, SUGERENCIA from RESERVACION";
            SqlCommand comando = new SqlCommand(cadenaconec, conexion);
            SqlDataReader reser = comando.ExecuteReader();
            while (reser.Read())
            {
                string nombre = reser["NOMBRE"].ToString();
                DateTime fecha = DateTime.Parse(reser["FECHA_HORA"].ToString());
                int numero = int.Parse(reser["NUMERO_PERSONAS"].ToString());
                string ubicacion = reser["UBICACION"].ToString();
                string sugerencia = reser["SUGERENCIA"].ToString();
                Reservation temp = new Reservation(nombre, fecha, numero, ubicacion, sugerencia);

                lstReser.Add(temp);
            }
            disconnectDB(conexion);
            return lstReser;
        }

        public List<Reservation> consulta_reservation(string fech)
        {
            List<Reservation> lstReser = new List<Reservation>();
            SqlConnection conexion = connectionDB();
            String cadenaconec = "SELECT NOMBRE, FECHA_HORA, NUMERO_PERSONAS, UBICACION, SUGERENCIA from RESERVACION WHERE FECHA_HORA BETWEEN '" + fech + " 00:00:00.0000000' AND '"+fech+ " 23:59:59.9999999' ";
            SqlCommand comando = new SqlCommand(cadenaconec, conexion);
            SqlDataReader reser = comando.ExecuteReader();
            while (reser.Read())
            {
                string nombre = reser["NOMBRE"].ToString();
                DateTime fecha = DateTime.Parse(reser["FECHA_HORA"].ToString());
                int numero = int.Parse(reser["NUMERO_PERSONAS"].ToString());
                string ubicacion = reser["UBICACION"].ToString();
                string sugerencia = reser["SUGERENCIA"].ToString();
                Reservation temp = new Reservation(nombre, fecha, numero, ubicacion, sugerencia);

                lstReser.Add(temp);
            }
            disconnectDB(conexion);
            return lstReser;
        }

        public string delete_reserv(string nombre)
        {
            string msj = null;
            try
            {
                SqlConnection conexion = connectionDB();
                String delete = "DELETE RESERVACION  WHERE NOMBRE = @NOMBRE";
                SqlCommand comando = new SqlCommand(delete, conexion);

                comando.Parameters.AddWithValue("NOMBRE", nombre);

                int resultado = comando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    msj = "Registro Eliminado";
                }
                else
                {
                    msj = "Registro no se pudo eliminar";
                }
                disconnectDB(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                msj = "No se encontro el registo";
            }

            return msj;
        }

        /*public string delete_user(string cedula)
        {
            string msj = null;
            try
            {
                SqlConnection conexion = connectionDB();
                String delete = "DELETE USUARIO  WHERE CEDULA = @CEDULA";
                SqlCommand comando = new SqlCommand(delete, conexion);

                comando.Parameters.AddWithValue("CEDULA", cedula);

                int resultado = comando.ExecuteNonQuery();
                if (resultado == 1)
                {
                    msj = "Registro Eliminado";
                }
                else
                {
                    msj = "Registro no se pudo eliminar";
                }
                disconnectDB(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                msj = "No se encontro el registo";
            }

            return msj;
        }*/
    }
}
