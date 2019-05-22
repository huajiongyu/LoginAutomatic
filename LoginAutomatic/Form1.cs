using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginAutomatic
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser WebBrowser = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cef.Initialize(new CefSettings());
            WebBrowser = new ChromiumWebBrowser();

            WebBrowser.FrameLoadEnd += Web_FrameLoadEnd;

            WebBrowser.Location = new Point(634, 79);
            //webbrowser.Anchor = AnchorStyles.Bottom;// | AnchorStyles.Left | AnchorStyles.Right;
            WebBrowser.Dock = DockStyle.Bottom;
            WebBrowser.Size = new Size(600, 240);
            this.Controls.Add(WebBrowser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser.Load(url.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String script = scripts.Text;
            var result = this.WebBrowser.EvaluateScriptAsync(script).Result.Result;
            //MessageBox.Show(result.ToString());
        }

        //
        private async void Web_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            string script = scripts.Text;

            e.Browser.MainFrame.ExecuteJavaScriptAsync(script);

            e.Browser.MainFrame.ExecuteJavaScriptAsync("document.getElementById('kw').value='在C#里面给页面文本框进行赋值'");

            //你可以做你任何想做的事了
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            StepManager s = new StepManager();
            s.ShowDialog();
            this.Visible = true;
        }
    }
}
