using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace SoapServiceAuthPractice;

public class SoapServiceClient
{
    private readonly HttpClient _httpClient;
    private readonly string _soapServiceUrl;
    public SoapServiceClient(string soapServiceUrl)
    {
        this._httpClient = new HttpClient();
        this._soapServiceUrl = soapServiceUrl;
    }
    public async Task<dynamic> LoginAsync(string userName, string password)
    {
        try
        {
            string method = "Login";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("UserName", userName),
                    new KeyValuePair<string, string>("Password", password)
                };

            string result = await this.PostAsync(method, parameters);
            return result;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<dynamic> LogoutAsync(string loginToken)
    {
        try
        {

            string method = "Logout";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("LoginToken", loginToken)
                };

            string result = await this.PostAsync(method, parameters);
            return result;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<dynamic> SubmitReportAsync(string loginToken, string xmlReport)
    {
        try
        {
            string method = "SubmitReport";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("LoginToken", loginToken),
                    new KeyValuePair<string, string>("XMLReport", xmlReport)
                };

            string result = await this.PostAsync(method, parameters);
            return result;
        }
        catch (Exception)
        {

            throw;
        }
    }

    private async Task<string> PostAsync(string method, List<KeyValuePair<string, string>> parameters)
    {
        string result = string.Empty;
        try
        {
            string soapDoc = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            soapDoc += CreatSoapDocument(method, parameters);

            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri(this._soapServiceUrl),
                Method = HttpMethod.Post
            };

            requestMessage.Content = new StringContent(soapDoc, Encoding.UTF8, "text/xml");

            requestMessage.Headers.Clear();
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
            requestMessage.Headers.Add("SOAPAction", string.Format("http://titanportalws.gov/{0}", method));

            var responseMessage = await this._httpClient.SendAsync(requestMessage);

            if (responseMessage.IsSuccessStatusCode)
            {
                result = await responseMessage.Content.ReadAsStringAsync();
                result = ReformatResult(result);
            }
        }
        catch (Exception ex)
        {
            throw;
        }

        return result;
    }
    private string ReformatResult(string result)
    {
        string ret = result;
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(result);
            ret = xmlDoc.InnerText;
        }
        catch { }

        return ret;
    }

    private string CreatSoapDocument(string soapMethod, List<KeyValuePair<string, string>> parameters)
    {
        XNamespace ns = "http://schemas.xmlsoap.org/soap/envelope/";
        XNamespace myns = "http://titanportalws.gov/";

        XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        XNamespace xsd = "http://www.w3.org/2001/XMLSchema";

        var items = parameters.Select(p => new XElement(myns + p.Key, p.Value)).ToArray();

        XDocument soapRequest = new XDocument(
        new XDeclaration("1.0", "utf-8", "no"),
        new XElement(ns + "Envelope",
            new XAttribute(XNamespace.Xmlns + "xsi", xsi),
            new XAttribute(XNamespace.Xmlns + "xsd", xsd),
            new XAttribute(XNamespace.Xmlns + "soap", ns),
            new XElement(ns + "Body",
                new XElement(myns + soapMethod, items)
            )
        ));

        return soapRequest.ToString();
    }
}
