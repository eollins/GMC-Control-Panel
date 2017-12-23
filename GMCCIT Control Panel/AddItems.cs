using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GMCCIT_Control_Panel
{
    public partial class AddItems : Form
    {
        string authToken = "";
        List<eBayItem> items = new List<eBayItem>();
        public AddItems()
        {
            InitializeComponent();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {

        }

        private async void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Loading consignment name...";
            WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetConsignmentName?consignmentID=" + numericUpDown1.Value);
            WebResponse response = await request.GetResponseAsync();
            string text = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();
            textBox1.Text = text.Substring(1, text.Length - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://api.ebay.com/ws/api.dll");
                var request = new RestRequest(Method.POST);
                request.AddHeader("postman-token", "6980ca77-0d9e-fac6-1e1b-56dc760a9794");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("x-ebay-api-siteid", "0");
                request.AddHeader("x-ebay-api-call-name", "GetSessionID");
                request.AddHeader("x-ebay-api-compatibility-level", "967");
                request.AddHeader("content-type", "text/xml");
                request.AddHeader("x-ebay-api-cert-name", "PRD-45ed603527c9-2461-4859-9906-7f37");
                request.AddHeader("x-ebay-api-dev-name", "8105fd0e-a76c-4e10-80e8-43e86ab59f7c");
                request.AddHeader("x-ebay-api-app-name", "GregoryM-mailer-PRD-a45ed6035-97c14545");
                request.AddParameter("text/xml", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<GetSessionIDRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">>\r\n  <RuName>Gregory_Morris_-GregoryM-mailer-viaojj</RuName>\r\n  <ErrorLanguage>en_US</ErrorLanguage>\r\n  <Version>967</Version>\r\n  <WarningLevel>High</WarningLevel>\r\n</GetSessionIDRequest>", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response.Content);
                string sessionID = ((XmlElement)doc.GetElementsByTagName("GetSessionIDResponse")[0]).GetElementsByTagName("SessionID")[0].InnerText;

                Process.Start("https://signin.ebay.com/ws/eBayISAPI.dll?SignIn&runame=Gregory_Morris_-GregoryM-mailer-viaojj&SessID=" + sessionID);
                MessageBox.Show("Click \"OK\" when finished logging in");

                var client2 = new RestClient("https://api.ebay.com/ws/api.dll");
                var request2 = new RestRequest(Method.POST);
                request2.AddHeader("postman-token", "c78a3e02-73e2-d161-e5f2-b3407b7ce080");
                request2.AddHeader("cache-control", "no-cache");
                request2.AddHeader("x-ebay-api-siteid", "0");
                request2.AddHeader("x-ebay-api-call-name", "FetchToken");
                request2.AddHeader("x-ebay-api-compatibility-level", "967");
                request2.AddHeader("content-type", "text/xml");
                request2.AddHeader("x-ebay-api-cert-name", "PRD-45ed603527c9-2461-4859-9906-7f37");
                request2.AddHeader("x-ebay-api-dev-name", "8105fd0e-a76c-4e10-80e8-43e86ab59f7c");
                request2.AddHeader("x-ebay-api-app-name", "GregoryM-mailer-PRD-a45ed6035-97c14545");
                request2.AddParameter("text/xml", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FetchTokenRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">\r\n  <SessionID>" + sessionID + "</SessionID>\r\n  <ErrorLanguage>en_US</ErrorLanguage>\r\n  <Version>967</Version>\r\n  <WarningLevel>High</WarningLevel>\r\n</FetchTokenRequest>", ParameterType.RequestBody);
                IRestResponse response2 = client2.Execute(request2);

                XmlDocument doc2 = new XmlDocument();
                doc2.LoadXml(response2.Content);
                authToken = ((XmlElement)doc2.GetElementsByTagName("FetchTokenResponse")[0]).GetElementsByTagName("eBayAuthToken")[0].InnerText;
                button1.Enabled = false;
                panel1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Authentication failed.");
            }

            //try
            //{
            //    var client3 = new RestClient("https://api.ebay.com/ws/api.dll");
            //    var request3 = new RestRequest(Method.POST);
            //    request3.AddHeader("postman-token", "d785b88a-a6c4-0cc3-cdb0-b7a8e216f868");
            //    request3.AddHeader("cache-control", "no-cache");
            //    request3.AddHeader("x-ebay-api-siteid", "0");
            //    request3.AddHeader("x-ebay-api-call-name", "GetSellerList");
            //    request3.AddHeader("x-ebay-api-compatibility-level", "967");
            //    request3.AddHeader("content-type", "text/xml");
            //    request3.AddHeader("x-ebay-api-cert-name", "PRD-45ed603527c9-2461-4859-9906-7f37");
            //    request3.AddHeader("x-ebay-api-dev-name", "8105fd0e-a76c-4e10-80e8-43e86ab59f7c");
            //    request3.AddHeader("x-ebay-api-app-name", "GregoryM-mailer-PRD-a45ed6035-97c14545");
            //    request3.AddParameter("text/xml", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<GetSellerListRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">\r\n  <RequesterCredentials>\r\n    <eBayAuthToken>" + authToken + "</eBayAuthToken>\r\n  </RequesterCredentials>\r\n  <ErrorLanguage>en_US</ErrorLanguage>\r\n  <WarningLevel>High</WarningLevel>\r\n  <GranularityLevel>Coarse</GranularityLevel> \r\n  <StartTimeFrom>" + DateTime.Now.AddHours(-18).ToString("yyyy-MM-ddTHH:mm:ss.fff") + "</StartTimeFrom> \r\n  <StartTimeTo>" + DateTime.Now.AddHours(-8).ToString("yyyy-MM-ddTHH:mm:ss.fff") + "</StartTimeTo> \r\n  <IncludeWatchCount>true</IncludeWatchCount> \r\n  <Pagination> \r\n    <EntriesPerPage>200</EntriesPerPage> \r\n  </Pagination> \r\n</GetSellerListRequest>", ParameterType.RequestBody);
            //    IRestResponse response3 = client3.Execute(request3);

            //    XmlDocument doc = new XmlDocument();
            //    doc.LoadXml(response3.Content);
            //    int pageCount = int.Parse(((XmlElement)((XmlElement)doc.GetElementsByTagName("GetSellerListResponse")[0]).GetElementsByTagName("PaginationResult")[0]).GetElementsByTagName("TotalNumberOfPages")[0].InnerText);

            //    for (int i = 2; i <= pageCount; i++)
            //    {
            //        var client4 = new RestClient("https://api.ebay.com/ws/api.dll");
            //        var request4 = new RestRequest(Method.POST);
            //        request4.AddHeader("postman-token", "d785b88a-a6c4-0cc3-cdb0-b7a8e216f868");
            //        request4.AddHeader("cache-control", "no-cache");
            //        request4.AddHeader("x-ebay-api-siteid", "0");
            //        request4.AddHeader("x-ebay-api-call-name", "GetSellerList");
            //        request4.AddHeader("x-ebay-api-compatibility-level", "967");
            //        request4.AddHeader("content-type", "text/xml");
            //        request4.AddHeader("x-ebay-api-cert-name", "PRD-45ed603527c9-2461-4859-9906-7f37");
            //        request4.AddHeader("x-ebay-api-dev-name", "8105fd0e-a76c-4e10-80e8-43e86ab59f7c");
            //        request4.AddHeader("x-ebay-api-app-name", "GregoryM-mailer-PRD-a45ed6035-97c14545");
            //        request4.AddParameter("text/xml", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<GetSellerListRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">\r\n  <RequesterCredentials>\r\n    <eBayAuthToken>" + authToken + "</eBayAuthToken>\r\n  </RequesterCredentials>\r\n  <ErrorLanguage>en_US</ErrorLanguage>\r\n  <WarningLevel>High</WarningLevel>\r\n  <GranularityLevel>Coarse</GranularityLevel> \r\n  <StartTimeFrom>" + DateTime.Now.AddHours(-9).ToString("yyyy-MM-ddTHH:mm:ss.fff") + "</StartTimeFrom> \r\n  <StartTimeTo>" + DateTime.Now.AddHours(-8).ToString("yyyy-MM-ddTHH:mm:ss.fff") + "</StartTimeTo> \r\n  <IncludeWatchCount>true</IncludeWatchCount> \r\n  <Pagination> \r\n    <PageNumber>" + i + "</PageNumber>  \r\n   <EntriesPerPage>200</EntriesPerPage> \r\n  </Pagination> \r\n</GetSellerListRequest>", ParameterType.RequestBody);
            //        IRestResponse response4 = client4.Execute(request4);

            //        XmlDocument doc2 = new XmlDocument();
            //        doc2.LoadXml(response4.Content);
            //        XmlNodeList nodes = ((XmlElement)((XmlElement)doc.GetElementsByTagName("GetSellerListResponse")[0]).GetElementsByTagName("ItemArray")[0]).GetElementsByTagName("Item");

            //        foreach (XmlElement el in nodes)
            //        {
            //            eBayItem item = new eBayItem();
            //            item.ItemNumber = el.GetElementsByTagName("ItemID")[0].InnerText;
            //            item.SKU = el.GetElementsByTagName("SKU")[0].InnerText;
            //            items.Add(item);
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Could not retrieve item data.");
            //    this.Close();
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string prefix = textBox3.Text;
            int min = int.Parse(textBox5.Text);
            int max = int.Parse(textBox2.Text);

            progressBar1.Maximum = (max - min) + 1;
            progressBar1.Value = 0;

            button6.Enabled = false;
            numericUpDown1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

            List<string> skus = new List<string>();
            for (int i = min; i <= max; i++)
            {
                string sku = "";
                if (i > 10000)
                {
                    sku = prefix + i;
                }
                else if (i < 10000 && i >= 1000)
                {
                    sku = prefix + "0" + i;
                }
                else if (i < 1000 && i >= 100)
                {
                    sku = prefix + "00" + i;
                }
                else if (i < 100 && i >= 10)
                {
                    sku = prefix + "000" + i;
                }
                else
                {
                    sku = prefix + "0000" + i;
                }
                skus.Add(sku);
            }

                int pageNumber = 5000;
            for (int i2 = 1; i2 <= pageNumber; i2++)
            {
                WebRequest itemNumberRequest = WebRequest.Create("https://api.ebay.com/ws/api.dll");
                itemNumberRequest.Method = "POST";
                itemNumberRequest.ContentType = "text/xml";
                itemNumberRequest.Headers.Add("x-ebay-api-siteid", "0");
                itemNumberRequest.Headers.Add("x-ebay-api-call-name", "GetSellerList");
                itemNumberRequest.Headers.Add("x-ebay-api-compatibility-level", "967");
                itemNumberRequest.Headers.Add("x-ebay-api-cert-name", "PRD-45ed603527c9-2461-4859-9906-7f37");
                itemNumberRequest.Headers.Add("x-ebay-api-dev-name", "8105fd0e-a76c-4e10-80e8-43e86ab59f7c");
                itemNumberRequest.Headers.Add("x-ebay-api-app-name", "GregoryM-mailer-PRD-a45ed6035-97c14545");

                XmlDocument doc = new XmlDocument();
                doc.Load("CallBase.xml");
                ((XmlElement)doc.GetElementsByTagName("GetSellerListRequest")[0]).GetElementsByTagName("StartTimeFrom")[0].InnerText = DateTime.Now.AddHours(-8).AddMonths(-2).ToString("yyyy-MM-ddTHH:mm:ss.fff");
                ((XmlElement)doc.GetElementsByTagName("GetSellerListRequest")[0]).GetElementsByTagName("StartTimeTo")[0].InnerText = DateTime.Now.AddHours(-8).ToString("yyyy-MM-ddTHH:mm:ss.fff");
                ((XmlElement)((XmlElement)doc.GetElementsByTagName("GetSellerListRequest")[0]).GetElementsByTagName("RequesterCredentials")[0]).GetElementsByTagName("eBayAuthToken")[0].InnerText = authToken;
                ((XmlElement)((XmlElement)doc.GetElementsByTagName("GetSellerListRequest")[0]).GetElementsByTagName("Pagination")[0]).GetElementsByTagName("PageNumber")[0].InnerText = i2.ToString();

                for (int i3 = 0; i3 < skus.Count; i3++)
                {
                    XmlElement ele = doc.CreateElement("SKU");
                    ele.InnerText = skus[i3];
                    ((XmlElement)doc.GetElementsByTagName("GetSellerListRequest")[0]).GetElementsByTagName("SKUArray")[0].AppendChild(ele);
                }

                itemNumberRequest.ContentLength = doc.InnerXml.Length;

                byte[] data2 = new ASCIIEncoding().GetBytes(doc.InnerXml);
                itemNumberRequest.GetRequestStream().Write(data2, 0, doc.InnerXml.Length);

                WebResponse resp = itemNumberRequest.GetResponse();
                string xml = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                XmlDocument result = new XmlDocument();
                result.LoadXml(xml);

                XmlNodeList nodes = ((XmlElement)((XmlElement)result.GetElementsByTagName("GetSellerListResponse")[0]).GetElementsByTagName("ItemArray")[0]).GetElementsByTagName("Item");
                foreach (XmlElement ele in nodes)
                {
                    NewItem item = new NewItem();
                    item.ItemNumber = ele.GetElementsByTagName("ItemID")[0].InnerText;
                    item.ConsignmentID = numericUpDown1.Value.ToString();
                    item.SKU = ele.GetElementsByTagName("SKU")[0].InnerText;
                    item.IsTest = "0";
                    string json = JsonConvert.SerializeObject(item);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/AddItem");
                    request.Method = "POST";
                    request.ContentType = "application/json";
                    request.ContentLength = json.Length;

                    request.GetRequestStream().Write(data, 0, json.Length);
                    WebResponse response = await request.GetResponseAsync();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string responseText = await reader.ReadToEndAsync();

                    if (responseText == "1")
                    {
                        progressBar1.Value++;
                    }
                }

                pageNumber = int.Parse(((XmlElement)((XmlElement)result.GetElementsByTagName("GetSellerListResponse")[0]).GetElementsByTagName("PaginationResult")[0]).GetElementsByTagName("TotalNumberOfPages")[0].InnerText);
            }

            button6.Enabled = true;
            numericUpDown1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }
    }
}
