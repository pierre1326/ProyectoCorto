using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCorto
{
    public partial class Form1 : Form
    {
        public delegate void delUpdateUIBrowser();
        public delegate void delHTMLBrowser();
        public string UrlConsulta { get; set; } = "https://www.consulta.tse.go.cr/consulta_persona/consulta_cedula.aspx";
        public string ButtonName { get; set; } = "Button1";
        public string ButtonHijos { get; set; } = "btnMostrarNacimiento";
        public string ButtonVotacion { get; set; } = "btnMostrarVotacion";
        public string LabelName { get; set; } = "txtcedula";
        public Boolean searchAvailable { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(ProcessHtml);
            tabPage1.Text = "Consulta por cedula";
            tabPage2.Text = "Informacion Recuperada";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchAvailable = true;
            button1.Enabled = false;
            error.Visible = false;
            webBrowser.Navigate(UrlConsulta);          
        }
        private void ProcessHtml(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (searchAvailable)
            {
                searchAvailable = false;
                WebBrowser browser = webBrowser;
                browser.Document.GetElementById(LabelName).InnerText = textBox.Text;
                browser.Document.GetElementById(ButtonName).InvokeMember("click");
            }
            else
            {
                try
                {
                    WebBrowser browser = webBrowser;
                    browser.Document.GetElementById(ButtonVotacion).InvokeMember("click");
                    ThreadStart threadStart = new ThreadStart(ThreadStartHTML);
                    Thread thread = new Thread(threadStart);
                    thread.Start();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                    error.Visible = true;
                }
                
            }
        }
        private void ThreadStartHTML()
        {
            Thread.Sleep(3000);
            delUpdateUIBrowser DelUpdateUIBrowser = new delUpdateUIBrowser(showData);
            webBrowser.BeginInvoke(DelUpdateUIBrowser);
        }
        private void showData()
        {
            WebBrowser browser = webBrowser;
            mshtml.HTMLDocument doc = browser.Document.DomDocument as mshtml.HTMLDocument;
            string html = doc.documentElement.outerHTML;
            getData(doc);
            button1.Enabled = true;
        }

        private void getData(mshtml.HTMLDocument doc)
        {
            mshtml.IHTMLElement grid = doc.getElementById("Gridvotacion");
            List<string> datos = iterateTable(grid.innerHTML);
            cedula.Text = doc.getElementById("lblcedula").innerText;
            edad.Text = doc.getElementById("lbledad").innerText;
            nombre.Text = doc.getElementById("lblnombrecompleto").innerText;
            conocido.Text = doc.getElementById("lblconocidocomo").innerText;
            fecha.Text = doc.getElementById("lblfechaNacimiento").innerText;
            madre.Text = doc.getElementById("lblnombremadre").innerText;
            cedulaMadre.Text = doc.getElementById("lblid_madre").innerText;
            padre.Text = doc.getElementById("lblnombrepadre").innerText;
            cedulaPadre.Text = doc.getElementById("lblid_padre").innerText;
            nacionalidad.Text = doc.getElementById("lblnacionalidad").innerText;
            marginal.Text = doc.getElementById("lblLeyendaMarginal").innerText;
            provincia.Text = datos[0];
            canton.Text = datos[1];
            distrito.Text = datos[2];
        }
        private List<string> iterateTable(String table)
        {
            List<string> result = new List<string>();
            char[] list = table.ToCharArray();
            for (int i = 0; i < list.Length; i++)
            {
                char x = list[i];
                if (x == '"')
                {                
                    char prev = list[i - 1];
                    char prevprev = list[i - 2];
                    char next = list[i + 1];
                    if (prev == '=' && prevprev == 'n' && next != '"')
                    {
                        String newData = "";
                        int j = i + 1;
                        char temp = list[j];
                        do
                        {
                            newData += temp;
                            j += 1;
                            temp = list[j];                      
                        }
                        while (temp != '"');
                        result.Add(newData);
                        Console.WriteLine(newData);
                    }       
                }
            }
            return result;
        }

        private void textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string text = textBox.Text;
            if (text.Length < 9)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
