using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pferramenta0030482421045
{
    internal class Fabricante
    {
        public int IdFabricante { get; set; }

        public string NomeFantasia { get; set; }

        public DataTable listar()
        {

            SqlDataAdapter daFabricante;
            DataTable dtFabricante = new DataTable();
            try
            {
                daFabricante = new SqlDataAdapter("SELECT * FROM FABRICANTE", frmPrincipal.conexao);
                daFabricante.Fill(dtFabricante);
                daFabricante.FillSchema(dtFabricante, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtFabricante;
        }
        public int Salvar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FABRICANTE VALUES (@nomeFantasia)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@descricao", SqlDbType.VarChar));

                mycommand.Parameters["@descricao"].Value = NomeFantasia;
                retorno = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Alterar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE FABRICANTE SET nomeFantasia = " + "@nomeFantasia WHERE id = @idfabricante", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("idfabricante", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("idnomeFantasia", SqlDbType.VarChar));

                mycommand.Parameters["@idfabricante"].Value = IdFabricante;
                mycommand.Parameters["@nomeFantasia"].Value = NomeFantasia;
                retorno = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }


        public int excluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM FABRICANTE WHERE id = @idfabricante", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("idfabricante", SqlDbType.Int));

                mycommand.Parameters["@idfabricante"].Value = IdFabricante;

                retorno = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }

}