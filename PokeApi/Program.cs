using Newtonsoft.Json;
using PokeApi.Pokemon;
using System;
using System.Net;
using System.Text.Json;

namespace PokeApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número ou nome do pokémon: ");
            string entrada = Console.ReadLine();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"https://pokeapi.co/api/v2/pokemon/{entrada}");
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            HttpStatusCode status = response.StatusCode;

            string statusResponse = status.ToString();

            if (status == HttpStatusCode.OK)
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                Root pokemon = JsonConvert.DeserializeObject<Root>(responseFromServer);

                Console.WriteLine("");
                Console.Write($"Número do pokemon: {pokemon.id}");
                Console.WriteLine("");
                Console.Write($"Nome do pokemon: {pokemon.name}");
                Console.WriteLine("");
                if (pokemon.is_default == true)
                    Console.Write($"Pokémon inicial: Sim");
                else
                    Console.WriteLine($"Pokémon inicial: Não");
                Console.WriteLine();
                Console.WriteLine($"Peso do Pokémon:{pokemon.weight} kilos");


                #region MELHORAR E ADAPTAR ESSE CÓDIGO AQUI

                //Console.WriteLine($"Encontro da área de localização: {pokemon.location_area_encounters}");

                // ============================NOVO REQUEST PARA LOCALIZAÇÃO ====================================================== //

                // ver essa parte depois!

                //string newRequest = $"https://pokeapi.co/api/v2/pokemon/{pokemon.id}/encounters";


                //HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create(newRequest);
                //HttpWebResponse response2 = (HttpWebResponse)req2.GetResponse();
                //HttpStatusCode status2 = response.StatusCode;

                //Stream newDataStream = response2.GetResponseStream();
                //StreamReader newReader = new StreamReader(newDataStream);
                //string newResponseFromServer = newReader.ReadToEnd();

                //Localizacao[] loc = JsonConvert.DeserializeObject<Localizacao[]>(newResponseFromServer);
                //foreach (var item in loc)
                //{
                //    Console.WriteLine($"localização do pokemon:{item.url}");
                //}


                #endregion

            }


        }
    }
}
