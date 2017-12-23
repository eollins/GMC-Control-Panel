using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMCCIT_Control_Panel
{
    public partial class NewConsignment : Form
    {
        public NewConsignment()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
            }
        }

        private async void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Loading username...";
            WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetUsername?userID=" + numericUpDown1.Value);
            WebResponse response = await request.GetResponseAsync();
            string text = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();
            textBox5.Text = text.Substring(1, text.Length - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentInfo ci = new ConsignmentInfo();
                ci.SKUMin = textBox1.Text;
                ci.SKUMax = textBox2.Text;
                ci.ConsignmentName = textBox3.Text;
                ci.Total = textBox4.Text;
                ci.IsTest = 0;
                string json = JsonConvert.SerializeObject(ci);
                byte[] data = new ASCIIEncoding().GetBytes(json);

                WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/AddConsignment");
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = json.Length;

                request.GetRequestStream().Write(data, 0, json.Length);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseText = reader.ReadToEnd();

                if (checkBox1.Checked)
                {
                    WebRequest idRequest = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetConsignmentID?consignmentName=" + textBox3.Text);
                    WebResponse idResponse = idRequest.GetResponse();
                    string body = new StreamReader(idResponse.GetResponseStream()).ReadToEnd();

                    Assignment a = new Assignment();
                    a.UserID = (int)numericUpDown1.Value;
                    a.ConsignmentID = int.Parse(body.Substring(1, body.Length - 2));
                    string json2 = JsonConvert.SerializeObject(a);
                    byte[] data2 = new ASCIIEncoding().GetBytes(json2);

                    WebRequest request2 = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/AssignConsignment");
                    request2.Method = "POST";
                    request2.ContentType = "application/json";
                    request2.ContentLength = json2.Length;

                    request2.GetRequestStream().Write(data2, 0, json2.Length);
                    WebResponse response2 = request2.GetResponse();
                    StreamReader reader2 = new StreamReader(response2.GetResponseStream());
                    string responseT = reader2.ReadToEnd();

                    if (responseText == "1" && responseT == "1")
                    {
                        MessageBox.Show("Success.");
                        this.Close();
                    }

                    if (responseText == "1" && responseT != "1")
                    {
                        MessageBox.Show("Consignment created, user not assigned");
                        this.Close();
                    }

                    if (responseText != "1")
                    {
                        MessageBox.Show("Addition failed.");
                    }
                }
                else
                {
                    if (responseText == "1")
                    {
                        MessageBox.Show("Success.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Addition failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
