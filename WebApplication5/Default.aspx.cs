using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{

    using CEPService;

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_ConsultarClick(object sender, EventArgs e)
        {
            var cep = txtCEP.Text;
            if (!string.IsNullOrEmpty(cep))
            {
                ConsultaCEP(cep);
            }
        }

        private void ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                //var resposta = ws.consultaCEP(cep);

                if (ws.consultaCEP(cep) != null)
                {
                    var resposta = ws.consultaCEP(cep);
                    String Endereco = resposta.end;
                    String Bairro = resposta.bairro;
                    String Cidade = resposta.cidade;
                    String Uf = resposta.uf;

                    String resultado = String.Format("<b>Logradouro:</b> {0}</br><b>Bairro:</b> {1}</br><b>Cidade:</b> {2}</br><b>UF:</b> {3}", Endereco, Bairro, Cidade, Uf);
                    litResultado.Text = resultado;
                }
                else
                {
                    litResultado.Text = "CEP Não Encontrado";
                }
            }
        }
    }
}