using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CDIS.Clients
{
    public class ClientRepository
    {
        public List<Client> Clients { get; }

        public ClientRepository()
        {
            var dataAssembly = GetType().GetTypeInfo().Assembly;
            Stream stream = dataAssembly.GetManifestResourceStream("CDIS.Clients.clients.json");
            
            var clientData = new List<Client>();

            using (var reader = new StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                clientData = JsonConvert.DeserializeObject<List<Client>>(json);
            }

            Clients = clientData;
        }
    }
}
