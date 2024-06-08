using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Datos;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prueba1
{
    public class DataAccess
    {

        private const string ConnectionString = "Server=DANIELPC\\SQLEXPRESS;Integrated Security=true;Initial Catalog=PRODUCTO";


        public List<InformacionDestacada> GetInformacionDestacada()
        {
            List<InformacionDestacada> list = new List<InformacionDestacada>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT p.Id AS PedidoId,
                                    c.Nombre AS ClienteNombre,
                                    pr.Nombre AS ProductoNombre,
                                    dp.Cantidad,
                                    pr.Precio AS PrecioUnitario,
                                    p.Fecha AS FechaPedido
                             FROM Pedidos p
                             JOIN Usuario c ON p.ClienteId = c.Id
                             JOIN DetallePedidos dp ON p.Id = dp.PedidoId
                             JOIN Productos pr ON dp.ProductoId = pr.Id";

                    list = conn.Query<InformacionDestacada>(query).ToList();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
        public int Delete(int id)
        {

            int result = 0;
            int result1 = 0; 

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString); conn.Open();

                string query = "DELETE FROM DetallePedidos WHERE PedidoId = @Id";

                result = conn.Execute(query, new { Id = id });

                string deletePedidosQuery = "DELETE FROM Pedidos WHERE Id = @Id";
                result1 = conn.Execute(deletePedidosQuery, new { Id = id });

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
            return result1;

        }

        //Para Clientes
        public List<Cliente2> GetAllClientes()
        {
            List<Cliente2> list = new List<Cliente2>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = " SELECT * FROM Usuario";

                    list = conn.Query<Cliente2>(query).ToList();

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;

        }

        public int InsertCliente(Cliente2 cliente)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Usuario (Id, Nombre, Direccion, Telefono, Email) VALUES (@Id, @Nombre, @Direccion, @Telefono, @Email)";

                    result = conn.Execute(query, new
                    {
                        Id = cliente.Id,
                        Nombre = cliente.Nombre,
                        Direccion = cliente.Direccion,
                        Telefono = cliente.Telefono,
                        Email = cliente.Email,
                    });

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return result;
        }

        public int UpdateCliente(Cliente2 cliente)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "UPDATE Usuario SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE Id = @Id";

                    result = conn.Execute(query, new
                    {
                        Id = cliente.Id,
                        Nombre = cliente.Nombre,
                        Direccion = cliente.Direccion,
                        Telefono = cliente.Telefono,
                        Email = cliente.Email
                    });

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


        public int DeleteCliente(int id)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Usuario WHERE Id = @Id";

                    result = conn.Execute(query, new { Id = id });

                    conn.Close();

                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }

        
        public List<Producto> GetAllProductos()
        {
            List<Producto> list = new List<Producto>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Productos";

                    list = conn.Query<Producto>(query).ToList();

                    conn.Close();
                }
            }
            catch(SqlException ex) {
                Console.WriteLine(ex.Message);
            }
            return list;

        }

        public int InsertProducto(Producto producto)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Productos(Id, Nombre, Precio) VALUES(@Id, @Nombre, @Precio)";

                    result = conn.Execute(query, new
                    {
                        Id = producto.Id,
                        Nombre = producto.Nombre,
                        Precio = producto.Precio
                    });

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public int UpdateProducto(Producto producto)
        {
            int result = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {

                    conn.Open();

                    string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio WHERE Id = @Id";


                    result = conn.Execute(query, new
                    {
                        Id = producto.Id,
                        Cliente = producto.Nombre,
                        Precio = producto.Precio,

                    });
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public int DeleteProducto(int id)
        {
            int result = 0;
            try
            {
                using(SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Productos WHERE Id = @Id";

                    result = conn.Execute(query, new { Id = id });

                    conn.Close();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }


        
    }
}

