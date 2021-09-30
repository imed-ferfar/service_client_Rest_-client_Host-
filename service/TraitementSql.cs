using Client2_Host_Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2_Host_Rest.service
{
    class TraitementSql
    {
        public static List<Demande> RecupererDemandes(string MotCle)
        {
            List<Demande> maListe = null; ;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:62954/api/");
                //HTTP GET
                var responseTask = client.GetAsync("demande?motCle="+ MotCle);
                responseTask.Wait();
                
                var resultat = responseTask.Result;
                if (resultat.IsSuccessStatusCode)
                {
                    var readTask = resultat.Content.ReadAsAsync<List<Demande>>();
                    readTask.Wait();
                    
                    var retour = readTask.Result;
                    maListe = retour;
                    
                    Console.WriteLine("Success");
                }
                else
                    Console.WriteLine("Error");
                }
                return maListe;
        }
    }
}
