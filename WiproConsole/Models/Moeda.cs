using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiproWebApp.Utils;

using System.IO;

namespace WiproWebApp.Models
{
    public class Moeda
    {
        public int Id { get; set; }
        public string DsMoeda { get; set; }
        public string DtInicio { get; set; }
        public string DtFim { get; set; }

        public Moeda GetItemFila()
        {
            Moeda retorno = new Moeda();
            string json = WebAPI.RequestGET("GetItemFila", string.Empty);
            retorno = JsonConvert.DeserializeObject<Moeda>(json);
            return retorno;
        }

    }
}
