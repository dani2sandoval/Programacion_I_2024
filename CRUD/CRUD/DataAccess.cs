using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Windows;
using System.Windows.Media.Media3D;

namespace CRUD
{
    public class DataAccess
    {
        public const string CONNECTION_CADENA_SQL = "Server=DANIELPC\\SQLEXPRESS;Integrated Security=true;Initial Catalog=VentasDB";

        public List<Ventas> GetAllDapper()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_CADENA_SQL))
                {
                    conn.Open();
                    string query = "SELECT v.id, v.cliente, v.idproducto, p.Nombre AS NombreProducto, v.cantidad, v.precio FROM Ventas1 v JOIN Product p ON v.idproducto = p.Id";
                    ventas = conn.Query<Ventas>(query).ToList();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ventas;
        }

        public int Create(Ventas ventas)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_CADENA_SQL))
                {
                    conn.Open();
                    string query = @"INSERT INTO Ventas1 (cliente, idproducto, cantidad, precio) VALUES (@cliente, @idproduct, @cantidad, @precio)";
                    result = conn.Execute(query, new
                    {
                        cliente = ventas.Cliente,
                        idproduct = ventas.Idproducto,
                        cantidad = ventas.cantidad,
                        precio = ventas.Precio
                    });
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public Ventas GetById(int idventas)
        {
            Ventas ventas = new Ventas();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_CADENA_SQL))
                {
                    conn.Open();
                    string query = "SELECT id, cliente, idproducto, cantidad, precio FROM Ventas1 WHERE id=@id";
                    ventas = conn.QuerySingle<Ventas>(query, new { id = idventas });
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ventas;
        }

        public int Update(Ventas ventas)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_CADENA_SQL))
                {
                    conn.Open();
                    string query = @"UPDATE Ventas1 SET cliente=@cliente, idproducto=@idproduct, cantidad=@cantidad, precio=@precio WHERE id=@id1";
                    result = conn.Execute(query, new
                    {
                        cliente = ventas.Cliente,
                        idproduct = ventas.Idproducto,
                        cantidad = ventas.cantidad,
                        precio = ventas.Precio,
                        id1 = ventas.Id
                    });
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_CADENA_SQL))
                {
                    conn.Open();
                    string query = @"DELETE FROM Ventas1 WHERE id= @id";
                    result = conn.Execute(query, new { Id = id });
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public List<Producto> GetProduct()
        {
            List<Producto> product = new List<Producto>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_CADENA_SQL))
                {
                    conn.Open();
                    string query = "SELECT id, Nombre FROM Product";
                    product = conn.Query<Producto>(query).ToList();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return product;
        }
    }
}
