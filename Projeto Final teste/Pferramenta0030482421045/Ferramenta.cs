using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;

namespace Pferramenta0030482421045
{
    internal class Ferramenta
    {
        public int IdFerramenta { get; set; }
        public String Nome { get; set; }
        public String Forncedor { get; set; }
        public char Distribuicao { get; set; }
        public DateTime DtCadastro { get; set; }
        public String SiteOficial { get; set; }
        public int IdCategoria { get; set; }
        public int IdFabricante { get; set; }
        public DataTable listar()
        {

            SqlDataAdapter daFerramenta;
            DataTable dtFerramenta = new DataTable();
            try
            {
                daFerramenta = new SqlDataAdapter("SELECT * FROM FERRAMENTA", frmPrincipal.conexao);
                daFerramenta.Fill(dtFerramenta);
                daFerramenta.FillSchema(dtFerramenta, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtFerramenta;
        }
        public int Salvar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FERRAMENTAS VALUES (@nomeFantasia)" + "(@nome,@distribuicao,@dtCadastro,@siteOficial, " + "@idCategoria,@idFabricante)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteOficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = DtCadastro;
                mycommand.Parameters["@siteoficial"].Value = SiteOficial;
                mycommand.Parameters["@idcategoria"].Value = IdCategoria;
                mycommand.Parameters["@idfabricante"].Value = IdFabricante;

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

                mycommand = new SqlCommand("UPDATE FABRICANTE SET nome = @nome" + "distribuicao=@distribuicao," + "dtcadastro=@cadastro, site=@siteoficial"+"idcategoria=@idcategoria, idfabricante=@idfabricante"+"WHERE id = @idferramenta", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("idferramenta", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                mycommand.Parameters["@idferramenta"].Value = IdFerramenta;
                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = DtCadastro;
                mycommand.Parameters["@siteoficial"].Value = SiteOficial;
                mycommand.Parameters["@idcategoria"].Value = IdCategoria;
                mycommand.Parameters["@idfabricante"].Value = IdFabricante;
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

                mycommand = new SqlCommand("DELETE FROM FABRICANTE WHERE id = @idferramenta", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("idferramenta", SqlDbType.Int));

                mycommand.Parameters["@idferramenta"].Value = IdFabricante;

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