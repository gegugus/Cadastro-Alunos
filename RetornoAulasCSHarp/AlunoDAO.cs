using RetornoAulasCSHarp;
using System.Data.SqlClient;
using System.Data;
using System;

public class AlunoDAO
{
    public void INSERT(Aluno aluno)
    {
        using (var conn = ConnBD.GetConnection())
        {
            string sql = "INSERT INTO Alunos (Nome, Email, Telefone, Imagem) VALUES (@nome, @email, @telefone, @imagem)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", aluno.NOME);
            cmd.Parameters.AddWithValue("@email", aluno.EMAIL);
            cmd.Parameters.AddWithValue("@telefone", aluno.TELEFONE);
            cmd.Parameters.Add("@imagem", SqlDbType.VarBinary).Value = (object)aluno.IMAGEM ?? DBNull.Value;
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable LIST()
    {
        using (var conn = ConnBD.GetConnection())
        {
            string sql = "SELECT Id, Nome, Email, Telefone, Imagem FROM Alunos";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    public void UPDATE(Aluno aluno)
    {
        using (var conn = ConnBD.GetConnection())
        {
            string sql = "UPDATE Alunos SET Nome=@nome, Email=@email, Telefone=@telefone, Imagem=@imagem WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", aluno.ID);
            cmd.Parameters.AddWithValue("@nome", aluno.NOME);
            cmd.Parameters.AddWithValue("@email", aluno.EMAIL);
            cmd.Parameters.AddWithValue("@telefone", aluno.TELEFONE);
            cmd.Parameters.Add("@imagem", SqlDbType.VarBinary).Value = (object)aluno.IMAGEM ?? DBNull.Value;
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void DELETE(int id)
    {
        using (var conn = ConnBD.GetConnection())
        {
            string sql = "DELETE FROM Alunos WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
