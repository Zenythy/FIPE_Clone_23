using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace FIPE_Clone.Controllers
{
    public class VeiculosController : Controller
    {
        public IActionResult Index()
        {
            GetMarca();
            return View();
        }

        public void GetMarca()
        {
            var options = new RestClientOptions("https://veiculos.fipe.org.br/api/veiculos")
            {
                MaxTimeout = -1,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36",
            };
            var client = new RestClient(options);
            var request = new RestRequest("ConsultarMarcas", Method.Post);
            request.AddHeader("authority", "veiculos.fipe.org.br");
            request.AddHeader("accept", "application/json, text/javascript, /; q=0.01");
            request.AddHeader("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            request.AddHeader("content-type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("cookie", "ROUTEID=.13; _ga=GA1.3.87079276.1701269498; _gid=GA1.3.973661406.1701269498; _gat=1; nav41729=138206997dba0a2b1c6b6a8d9c10|2_334");
            request.AddHeader("origin", "https://veiculos.fipe.org.br");
            request.AddHeader("referer", "https://veiculos.fipe.org.br/");
            request.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"119\", \"Chromium\";v=\"119\", \"Not?A_Brand\";v=\"24\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-requested-with", "XMLHttpRequest");

            var body = "codigoTabelaReferencia=303&codigoTipoVeiculo=1";
            request.AddParameter(body, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void GetModelo() {

            var options = new RestClientOptions("https://veiculos.fipe.org.br/api/veiculos")
            {
                MaxTimeout = -1,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36",
            };
            var client = new RestClient(options);
            var request = new RestRequest("ConsultarModelos", Method.Post);
            request.AddHeader("authority", "veiculos.fipe.org.br");
            request.AddHeader("accept", "application/json, text/javascript, */*; q=0.01");
            request.AddHeader("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            request.AddHeader("content-type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("cookie", "ROUTEID=.13; _ga=GA1.3.87079276.1701269498; _gid=GA1.3.973661406.1701269498; nav41729=138206997dba0a2b1c6b6a8d9c10|2_334");
            request.AddHeader("origin", "https://veiculos.fipe.org.br");
            request.AddHeader("referer", "https://veiculos.fipe.org.br/");
            request.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"119\", \"Chromium\";v=\"119\", \"Not?A_Brand\";v=\"24\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-requested-with", "XMLHttpRequest");
            var body = @"codigoTipoVeiculo=1&codigoTabelaReferencia=303&codigoModelo=&codigoMarca=59&ano=&codigoTipoCombustivel=&anoModelo=&modeloCodigoExterno=";
            request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

        }

        public void GetModeloAno() {

            var options = new RestClientOptions("https://veiculos.fipe.org.br/api/veiculos")
            {
                MaxTimeout = -1,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36",
            };
            var client = new RestClient(options);
            var request = new RestRequest("ConsultarAnoModelo", Method.Post);
            request.AddHeader("authority", "veiculos.fipe.org.br");
            request.AddHeader("accept", "application/json, text/javascript, */*; q=0.01");
            request.AddHeader("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            request.AddHeader("content-type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("cookie", "ROUTEID=.13; _ga=GA1.3.87079276.1701269498; _gid=GA1.3.973661406.1701269498; nav41729=138206997dba0a2b1c6b6a8d9c10|2_334");
            request.AddHeader("origin", "https://veiculos.fipe.org.br");
            request.AddHeader("referer", "https://veiculos.fipe.org.br/");
            request.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"119\", \"Chromium\";v=\"119\", \"Not?A_Brand\";v=\"24\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-requested-with", "XMLHttpRequest");
            var body = @"codigoTipoVeiculo=1&codigoTabelaReferencia=303&codigoModelo=8113&codigoMarca=59&ano=&codigoTipoCombustivel=&anoModelo=&modeloCodigoExterno=";
            request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

        }

        public void GetModeloAtravesAno() {

            var options = new RestClientOptions("")
            {
                MaxTimeout = -1,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36",
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://veiculos.fipe.org.br/api/veiculos/ConsultarModelosAtravesDoAno", Method.Post);
            request.AddHeader("authority", "veiculos.fipe.org.br");
            request.AddHeader("accept", "application/json, text/javascript, */*; q=0.01");
            request.AddHeader("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            request.AddHeader("content-type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("cookie", "ROUTEID=.13; _ga=GA1.3.87079276.1701269498; _gid=GA1.3.973661406.1701269498; nav41729=138206997dba0a2b1c6b6a8d9c10|2_334");
            request.AddHeader("origin", "https://veiculos.fipe.org.br");
            request.AddHeader("referer", "https://veiculos.fipe.org.br/");
            request.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"119\", \"Chromium\";v=\"119\", \"Not?A_Brand\";v=\"24\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-requested-with", "XMLHttpRequest");
            var body = @"codigoTipoVeiculo=1&codigoTabelaReferencia=303&codigoModelo=8113&codigoMarca=59&ano=2022-1&codigoTipoCombustivel=1&anoModelo=2022&modeloCodigoExterno=";
            request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

        }
    }
}
