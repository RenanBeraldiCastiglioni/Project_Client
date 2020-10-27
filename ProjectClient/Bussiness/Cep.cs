using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjectClient.Bussiness
{
    public class Cep
    {
        public string CEP { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        //Atributos de Controle 
        public int Status { get; set; }
        public string StatusMessage { get; set; }

        //Criar método publico estatico que (retorna Cep) e recebe string código (CEP)
        public static Cep Search(string cep)
        {
            var obj_cep = new Cep();

            string urlBusca = "https://ws.apicep.com/cep/" + cep + ".json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBusca);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            
            string json = string.Empty;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            jsonCepObject cepJson = JsonConvert.DeserializeObject<jsonCepObject>(json);

            if (cepJson.status == 200)
            {
                obj_cep.CEP = cepJson.code;
                obj_cep.Address = cepJson.address;
                obj_cep.District = cepJson.district;
                obj_cep.City = cepJson.city;
                obj_cep.State = cepJson.state;
            }
            obj_cep.Status = cepJson.status;
            obj_cep.StatusMessage = cepJson.statusText;

            return obj_cep;
        }
    }
    public class jsonCepObject
    {
        public int status { get; set; }
        public bool ok { get; set; }
        public string code { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public string statusText { get; set; }
    }
}