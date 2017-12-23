using Newtonsoft.Json;
using RestSharp;
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
using System.Xml;

namespace GMCCIT_Control_Panel
{
    public partial class Form1 : Form
    {
        User currentUser = new User();
        Consignment currentConsignment = new Consignment();
        Item currentItem = new Item();
        int currentUserID = 0;
        int currentConsignmentID = 0;
        int currentItemID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
            if (radioButton1.Checked)
            {
                try
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetUserID?username=" + identifier.Text);
                    WebResponse response = request.GetResponse();

                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string responseText = reader.ReadToEnd();
                    
                    label2.Text = responseText.Substring(1, responseText.Length - 2);

                    currentUserID = int.Parse(label2.Text);

                    username.Text = identifier.Text;
                    currentUser.Username = username.Text;

                    WebResponse passwordResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetPassword?userID=" + currentUserID).GetResponse();
                    string passwordA = new StreamReader(passwordResponse.GetResponseStream()).ReadToEnd();
                    password.Text = passwordA.Substring(1, passwordA.Length - 2);
                    currentUser.Password = passwordA.Substring(1, passwordA.Length - 2);

                    WebResponse emailResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetEmail?userID=" + currentUserID).GetResponse();
                    string emailA = new StreamReader(emailResponse.GetResponseStream()).ReadToEnd();
                    email.Text = emailA.Substring(1, emailA.Length - 2);
                    currentUser.Email = emailA.Substring(1, emailA.Length - 2);

                    WebResponse nameResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetName?userID=" + currentUserID).GetResponse();
                    string nameA = new StreamReader(nameResponse.GetResponseStream()).ReadToEnd();
                    name.Text = nameA.Substring(1, nameA.Length - 2);
                    currentUser.Name = nameA.Substring(1, nameA.Length - 2);

                    consignments.Items.Clear();
                    WebResponse consignmentsResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetConsignmentByUsername?username=" + identifier.Text).GetResponse();
                    string consignmentsA = new StreamReader(consignmentsResponse.GetResponseStream()).ReadToEnd();
                    string[] consignmentIDs = consignmentsA.Split(';')[0].Split(',');
                    consignmentIDs[0] = consignmentIDs[0].Substring(1);
                    foreach (string s in consignmentIDs)
                    {
                        consignments.Items.Add(s);
                    }

                    label1.Text = "";
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetConsignmentID?consignmentName=" + identifier.Text);
                    WebResponse response = request.GetResponse();

                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string responseText = reader.ReadToEnd();
                    
                    label2.Text = responseText.Substring(1, responseText.Length - 2);

                    label13.Text = "";

                    currentConsignmentID = int.Parse(label2.Text);

                    cName.Text = identifier.Text;
                    currentConsignment.ConsignmentName = cName.Text;

                    WebResponse userResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetUser?consignmentID=" + currentConsignmentID).GetResponse();
                    string userA = new StreamReader(userResponse.GetResponseStream()).ReadToEnd();
                    cUser.Text = userA.Substring(1, userA.Length - 2);
                    currentConsignment.UserID = userA.Substring(1, userA.Length - 2);

                    WebResponse skuResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetSKURange?consignmentID=" + currentConsignmentID).GetResponse();
                    string skuR = new StreamReader(skuResponse.GetResponseStream()).ReadToEnd();
                    skuMin.Text = skuR.Substring(1, skuR.Length - 2).Split(';')[0];
                    textBox9.Text = skuR.Substring(1, skuR.Length - 2).Split(';')[1];
                    currentConsignment.SKUMin = skuR.Substring(1, skuR.Length - 2).Split(',')[0];
                    currentConsignment.SKUMax = skuR.Substring(1, skuR.Length - 2).Split(',')[1];

                    WebResponse totalResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetTotal?consignmentID=" + currentConsignmentID).GetResponse();
                    string t = new StreamReader(totalResponse.GetResponseStream()).ReadToEnd();
                    total.Text = t.Substring(1, t.Length - 2);
                    currentConsignment.Total = t.Substring(1, t.Length - 2);

                    WebResponse netResponse = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetNetSales?consignmentID=" + currentConsignmentID).GetResponse();
                    string ns = new StreamReader(netResponse.GetResponseStream()).ReadToEnd();
                    net.Text = ns.Substring(1, ns.Length - 2);
                    currentConsignment.NetSales = ns.Substring(1, ns.Length - 2);

                    WebResponse received = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetReceived?consignmentID=" + currentConsignmentID).GetResponse();
                    string r = new StreamReader(received.GetResponseStream()).ReadToEnd();
                    rec.Text = r.Substring(1, r.Length - 2);
                    currentConsignment.Received = r.Substring(1, r.Length - 2);

                    WebResponse owedR = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetOwed?consignmentID=" + currentConsignmentID).GetResponse();
                    string o = new StreamReader(owedR.GetResponseStream()).ReadToEnd();
                    owed.Text = o.Substring(1, o.Length - 2);
                    currentConsignment.Owed = o.Substring(1, o.Length - 2);

                    WebResponse grossR = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetGrossSales?consignmentID=" + currentConsignmentID).GetResponse();
                    string g = new StreamReader(grossR.GetResponseStream()).ReadToEnd();
                    gross.Text = g.Substring(1, g.Length - 2);
                    currentConsignment.GrossSales = g.Substring(1, g.Length - 2);
                }
                catch (Exception ex)
                {
                    label13.Text = ex.Message;
                }
            }
            else if (radioButton3.Checked)
            {
                try
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/GetItemIDBySKU?SKU=" + identifier.Text);
                    WebResponse response = request.GetResponse();
                    string itemID = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    label2.Text = itemID.Substring(1, itemID.Length - 2);
                    currentItemID = int.Parse(itemID.Substring(1, itemID.Length - 2));

                    sku.Text = identifier.Text;
                    currentItem.SKU = identifier.Text;

                    WebRequest titleRequest = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/GetItemTitle?itemID=" + currentItemID);
                    WebResponse titleResponse = titleRequest.GetResponse();
                    string titleR = new StreamReader(titleResponse.GetResponseStream()).ReadToEnd();
                    title.Text = titleR.Substring(1, titleR.Length - 2);
                    currentItem.ItemTitle = titleR.Substring(1, titleR.Length - 2);

                    WebRequest numRequest = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/GetItemNumber?itemID=" + currentItemID);
                    WebResponse numResponse = numRequest.GetResponse();
                    string skuR = new StreamReader(numResponse.GetResponseStream()).ReadToEnd();
                    number.Text = skuR.Substring(1, skuR.Length - 2);
                    currentItem.ItemNumber = skuR.Substring(1, skuR.Length - 2);

                    WebRequest consignmentRequest = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/GetItemConsignmentID?itemID=" + currentItemID);
                    WebResponse consignmentResponse = consignmentRequest.GetResponse();
                    string conR = new StreamReader(consignmentResponse.GetResponseStream()).ReadToEnd();
                    iConID.Text = conR.Substring(1, conR.Length - 2);
                    currentItem.Consignment = conR.Substring(1, conR.Length - 2);
                }
                catch (Exception ex)
                {
                    label17.Text = ex.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                new NewUser().Show();
            }
            else if (radioButton2.Checked)
            {
                new NewConsignment().Show();
            }
            else
            {
                new AddItems().Show();
            }
        }

        private void cUser_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetUsername?userID=" + cUser.Text);

            try
            {
                WebResponse response = request.GetResponse();
                string body = new StreamReader(response.GetResponseStream()).ReadToEnd();
                MessageBox.Show(body.Substring(1, body.Length - 2));
            }
            catch
            {
                MessageBox.Show("No user found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user? This cannot be undone.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/RemoveUser?userID=" + currentUserID);
                        request.ContentLength = 0;
                        request.Method = "POST";
                        WebResponse response = request.GetResponse();
                        string text = new StreamReader(response.GetResponseStream()).ReadToEnd();
                        if (text == "1")
                        {
                            MessageBox.Show("User successfully removed.");
                            label2.Text = "0";
                            identifier.Clear();
                            username.Clear();
                            password.Clear();
                            email.Clear();
                            name.Clear();
                            label13.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Removal failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this consignment? This cannot be undone.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/RemoveConsignment?consignmentID=" + currentConsignmentID);
                        request.ContentLength = 0;
                        request.Method = "POST";
                        WebResponse response = request.GetResponse();
                        string text = new StreamReader(response.GetResponseStream()).ReadToEnd();
                        if (text == "1")
                        {
                            MessageBox.Show("Consignment successfully removed.");
                            label2.Text = "0";
                            identifier.Clear();
                            cUser.Clear();
                            skuMin.Clear();
                            textBox9.Clear();
                            cName.Clear();
                            total.Clear();
                            net.Clear();
                            owed.Clear();
                            rec.Clear();
                            gross.Clear();
                            label13.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Removal failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                userPanel.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                identifier.Text = "Username";
            }
            else if (radioButton2.Checked)
            {
                userPanel.Visible = false;
                panel1.Visible = true;
                panel2.Visible = false;
                identifier.Text = "Consignment Name";
            }
            else if (radioButton3.Checked)
            {
                userPanel.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                identifier.Text = "SKU";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                userPanel.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                identifier.Text = "Username";
            }
            else if (radioButton2.Checked)
            {
                userPanel.Visible = false;
                panel1.Visible = true;
                panel2.Visible = false;
                identifier.Text = "Consignment Name";
            }
            else if (radioButton3.Checked)
            {
                userPanel.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                identifier.Text = "SKU";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                userPanel.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                identifier.Text = "Username";
            }
            else if (radioButton2.Checked)
            {
                userPanel.Visible = false;
                panel1.Visible = true;
                panel2.Visible = false;
                identifier.Text = "Consignment Name";
            }
            else if (radioButton3.Checked)
            {
                userPanel.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                identifier.Text = "SKU";
            }
        }

        private void iConID_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/GetConsignmentName?consignmentID=" + iConID.Text);

            try
            {
                WebResponse response = request.GetResponse();
                string body = new StreamReader(response.GetResponseStream()).ReadToEnd();
                MessageBox.Show(body.Substring(1, body.Length - 2));
            }
            catch
            {
                MessageBox.Show("No consignment found.");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (radioButton1.Checked)
            {
                int successful = 0;
                int failed = 0;
                if (currentUser.Username != username.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeUsername");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeUsername cu = new ChangeUsername();
                    cu.UserID = currentUserID.ToString();
                    cu.NewUsernameString = username.Text;
                    string json = JsonConvert.SerializeObject(cu);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentUser.Username = username.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentUser.Password != password.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangePassword");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangePassword cp = new ChangePassword();
                    cp.UserID = currentUserID.ToString();
                    cp.NewPasswordString = password.Text;
                    string json = JsonConvert.SerializeObject(cp);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentUser.Password = password.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentUser.Email != email.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeEmail");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeEmail cp = new ChangeEmail();
                    cp.UserID = currentUserID.ToString();
                    cp.NewEmailString = email.Text;
                    string json = JsonConvert.SerializeObject(cp);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentUser.Email = email.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentUser.Name != name.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeName");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeName cp = new ChangeName();
                    cp.UserID = currentUserID.ToString();
                    cp.NewNameString = name.Text;
                    string json = JsonConvert.SerializeObject(cp);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentUser.Name = name.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                MessageBox.Show(successful + " succeeded, " + failed + " failed");
            }
            else if (radioButton2.Checked)
            {
                int successful = 0;
                int failed = 0;
                if (currentConsignment.UserID != cUser.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/AssignConsignment");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    Assignment a = new Assignment();
                    a.UserID = int.Parse(cUser.Text);
                    a.ConsignmentID = currentConsignmentID;
                    string json = JsonConvert.SerializeObject(a);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.UserID = cUser.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if ((currentConsignment.SKUMin != skuMin.Text || currentConsignment.SKUMax != textBox9.Text) || currentConsignment.SKUMin != skuMin.Text && currentConsignment.SKUMax != textBox9.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeSKURange");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeSKURange csr = new ChangeSKURange();
                    csr.ConsignmentID = currentConsignmentID;
                    csr.Min = skuMin.Text;
                    csr.Max = textBox9.Text;
                    string json = JsonConvert.SerializeObject(csr);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.SKUMin = skuMin.Text;
                        currentConsignment.SKUMax = textBox9.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentConsignment.ConsignmentName != cName.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeConsignmentName");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeConsignmentName ccn = new ChangeConsignmentName();
                    ccn.ConsignmentID = currentConsignmentID;
                    ccn.NewConsignmentNameString = cName.Text;
                    string json = JsonConvert.SerializeObject(ccn);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.ConsignmentName = cName.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentConsignment.Total != total.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeTotal");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeTotal ct = new ChangeTotal();
                    ct.ConsignmentID = currentConsignmentID;
                    ct.NewTotalString = total.Text;
                    string json = JsonConvert.SerializeObject(ct);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.Total = total.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentConsignment.NetSales != net.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeNetSales");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeAmount ca = new ChangeAmount();
                    ca.ConsignmentID = currentConsignmentID;
                    ca.NewMoneyMadeString = net.Text;
                    string json = JsonConvert.SerializeObject(ca);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.NetSales = net.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentConsignment.Received != rec.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeReceived");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeAmount ca = new ChangeAmount();
                    ca.ConsignmentID = currentConsignmentID;
                    ca.NewMoneyMadeString = rec.Text;
                    string json = JsonConvert.SerializeObject(ca);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.Received = rec.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentConsignment.Owed != owed.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeOwed");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeAmount ca = new ChangeAmount();
                    ca.ConsignmentID = currentConsignmentID;
                    ca.NewMoneyMadeString = owed.Text;
                    string json = JsonConvert.SerializeObject(ca);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.Owed = owed.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentConsignment.GrossSales != gross.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/User/ChangeGrossSales");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeAmount ca = new ChangeAmount();
                    ca.ConsignmentID = currentConsignmentID;
                    ca.NewMoneyMadeString = gross.Text;
                    string json = JsonConvert.SerializeObject(ca);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.GrossSales = gross.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                MessageBox.Show(successful + " succeeded, " + failed + " failed");
            }
            else
            {
                int successful = 0;
                int failed = 0;

                if (currentItem.ItemNumber != number.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/ChangeItemNumber");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeItemNumber cin = new ChangeItemNumber();
                    cin.ItemID = currentItemID.ToString();
                    cin.NewItemNumber = number.Text;
                    cin.IsTest = "0";
                    string json = JsonConvert.SerializeObject(cin);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentItem.ItemNumber = number.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentItem.Consignment != iConID.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/ChangeConsignmentID");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeConsignmentID cci = new ChangeConsignmentID();
                    cci.ItemID = currentItemID.ToString();
                    cci.NewConsignmentID = iConID.Text;
                    string json = JsonConvert.SerializeObject(cci);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentConsignment.GrossSales = gross.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                if (currentItem.SKU != sku.Text)
                {
                    WebRequest request = WebRequest.Create("http://gmcconsignmentapi.azurewebsites.net/api/Item/ChangeSKU");
                    request.Method = "POST";
                    request.ContentType = "application/json";

                    ChangeSKU s = new ChangeSKU();
                    s.itemID = currentItemID.ToString();
                    s.newSKU = sku.Text;
                    string json = JsonConvert.SerializeObject(s);
                    byte[] data = new ASCIIEncoding().GetBytes(json);

                    request.ContentLength = json.Length;
                    await request.GetRequestStream().WriteAsync(data, 0, json.Length);

                    WebResponse response = await request.GetResponseAsync();

                    string responseText = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

                    if (responseText == "1")
                    {
                        successful++;
                        currentItem.SKU = sku.Text;
                    }
                    else
                    {
                        failed++;
                    }
                }

                MessageBox.Show(successful + " succeeded, " + failed + " failed");
            }

            button4.Enabled = true;
        }

        private async void number_TextChanged(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://open.api.ebay.com/shopping?callname=GetSingleItem&responseencoding=XML&appid=GregoryM-mailer-PRD-a45ed6035-97c14545&siteid=0&version=967&ItemID=" + number.Text);
            WebResponse response = await request.GetResponseAsync();
            string xml = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string title2 = ((XmlElement)((XmlElement)doc.GetElementsByTagName("GetSingleItemResponse")[0]).GetElementsByTagName("Item")[0]).GetElementsByTagName("Title")[0].InnerText;
                title.Text = title2;
            }
            catch { }
        }
    }
}