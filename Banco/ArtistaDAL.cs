using Microsoft.Data.SqlClient;
using ScreenMusic.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenMusic.Banco;
namespace ScreenMusic.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> ListarArtistas()
        {
            var listaArtistas = new List<Artista>();

            using var connection = new Connection().ObterConexao();
            connection.Open();

            string queryString = "SELECT * FROM Artista;";
            SqlCommand commandString = new SqlCommand(queryString, connection);
            using SqlDataReader dataReader = commandString.ExecuteReader();

            while (dataReader.Read())
            {
                string nomeArtista = Convert.ToString(dataReader["Nome"]);
                string bioArtista = Convert.ToString(dataReader["Bio"]);
                int idArtista = Convert.ToInt32(dataReader["Id"]);
                Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };
                listaArtistas.Add(artista);
            }
            return listaArtistas;
        }
        public void AdicionarArtista(Artista artista)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string command = "INSERT INTO Artista (Nome,Bio,FotoPerfil ) VALUES (@nome, @bio, @fotoPerfil);";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            sqlCommand.Parameters.AddWithValue("@nome", artista.Nome);
            sqlCommand.Parameters.AddWithValue("@bio", artista.Bio);
            sqlCommand.Parameters.AddWithValue("@fotoPerfil", artista.FotoPerfil);

            int ret = sqlCommand.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {ret}");
        }

        public void AtualizarArtista(Artista artista)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();
             
            string command = "UPDATE Artista SET Nome = @nome, Bio = @bio, FotoPerfil = @fotoPerfil  WHERE Id = @id ";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            sqlCommand.Parameters.AddWithValue("@Id", artista.Id);
            sqlCommand.Parameters.AddWithValue("@nome", artista.Nome);
            sqlCommand.Parameters.AddWithValue("@bio", artista.Bio);
            sqlCommand.Parameters.AddWithValue("@fotoPerfil", artista.FotoPerfil);

            int ret = sqlCommand.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {ret}");

        }

        public void DeletarArtista(Artista artista)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string command = "DELETE FROM Artista  WHERE Id = @id ";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            sqlCommand.Parameters.AddWithValue("@Id", artista.Id);


            int ret = sqlCommand.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {ret}");

        }
    }
}
