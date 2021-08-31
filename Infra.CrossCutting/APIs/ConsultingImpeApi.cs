using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Infra.CrossCutting.APIs
{
    public static class ConsultingImpeApi
    {
        public static async Task<Cities> GetCities(string city)
        {
            Uri getUri = new Uri($"http://servicos.cptec.inpe.br/XML/listaCidades?city={city}");
            HttpClient client = new HttpClient();
            HttpRequestHeaders requestHeaders = client.DefaultRequestHeaders;

            requestHeaders.Add("Accept", "application/xml");

            HttpResponseMessage responseMessage = await client.GetAsync(getUri);
            HttpContent responseContent = responseMessage.Content;

            string xml = await responseContent.ReadAsStringAsync();
            Cities entity =  ConvertCityXmlObject(xml);

            return entity;
        }

        public static async Task<City> GetForecastWeather(int id)
        {
            Uri getUri = new Uri($"http://servicos.cptec.inpe.br/XML/cidade/7dias/{id}/previsao.xml");
            HttpClient client = new HttpClient();
            HttpRequestHeaders requestHeaders = client.DefaultRequestHeaders;

            requestHeaders.Add("Accept", "application/xml");

            HttpResponseMessage responseMessage = await client.GetAsync(getUri);
            HttpContent responseContent = responseMessage.Content;

            string xml = await responseContent.ReadAsStringAsync();
            City entity = ConvertForecastWeatherXmlObject(xml);

            return entity;
        }

        public static City ConvertForecastWeatherXmlObject(string cityXml)
        {
            XElement xml = XElement.Parse(cityXml);
            xml.Descendants().Where(element => (string)element == "null").Remove();
            xml.Descendants().Where(element => element.Elements().Count() == 1).Remove();

            byte[] byteArray = Encoding.UTF8.GetBytes(xml.ToString());

            MemoryStream stream = new MemoryStream(byteArray);
            XmlReader reader = XmlReader.Create(stream);
         
            XmlSerializer serializer = new XmlSerializer(typeof(City));
            City city = (City)serializer.Deserialize(reader);

            stream.Close();
            reader.Close();

            return city;
        }

        public static Cities ConvertCityXmlObject(string cityXml)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(cityXml);

            MemoryStream stream = new MemoryStream(byteArray);
            XmlReader reader = XmlReader.Create(stream);

            XmlSerializer serializer = new XmlSerializer(typeof(Cities));
            Cities city = (Cities)serializer.Deserialize(reader);

            stream.Close();
            reader.Close();

            return city;
        }
    }
}