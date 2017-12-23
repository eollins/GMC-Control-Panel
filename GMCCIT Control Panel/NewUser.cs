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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCredentials creds = new UserCredentials();
            creds.Username = textBox1.Text;
            creds.Password = textBox2.Text;
            creds.Email = textBox3.Text;
            creds.Name = textBox4.Text;
            creds.IsTest = 0;
            string json = JsonConvert.SerializeObject(creds);
            byte[] data = new ASCIIEncoding().GetBytes(json);

            WebRequest request = WebRequest.Create("https://gmcconsignmentapi.azurewebsites.net/api/User/AddUser");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = json.Length;

            request.GetRequestStream().Write(data, 0, json.Length);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();
            
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
}
