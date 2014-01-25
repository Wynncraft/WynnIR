using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatiN.Core;
using NUnit.Framework;

namespace WynnIR
{
    public partial class wynnir : System.Windows.Forms.Form
    {
        string city = "";
        int server = 1;
        int mins = 0;
        long a = Int64.MaxValue;
        public wynnir()
        {
            InitializeComponent();
            detlasB.Checked = true;
            timeB.SelectedIndex = 0;
        }
        private void openThread_Click(object sender, EventArgs e)
        {
            var browser = new IE("forums.wynncraft.com/threads/invasion-tracker.28/page-" + a.ToString());
            browser.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.Maximize);
            string post = "There will be a swarm on Server " + server.ToString() + " in " + city.ToString() + ". ";
            if (mins != 0) { post += "It will be in " + mins.ToString() + " minutes time.";  }
            else { post += "I am unsure how long it is until it starts."; }
            Clipboard.SetText(post);
        }
        #region Buttons
        private void ragniB_CheckedChanged(object sender, EventArgs e)
        {
            if (ragniB.Checked) { city = "Ragni"; }
        }
        private void detlasB_CheckedChanged(object sender, EventArgs e)
        {
            if (detlasB.Checked) { city = "Detlas"; }
        }
        private void nemractB_CheckedChanged(object sender, EventArgs e)
        {
            if (nemractB.Checked) { city = "Nemract"; }
        }
        private void almujB_CheckedChanged(object sender, EventArgs e)
        {
            if (almujB.Checked) { city = "Almuj"; }
        }
        #endregion
        #region Values
        private void serverB_ValueChanged(object sender, EventArgs e)
        {
            server = (int)serverB.Value;
        }
        private void timeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeB.SelectedItem.ToString() != "Unsure")
            {
                mins = Int16.Parse(timeB.SelectedItem.ToString());
            }
            else
            {
                mins = 0;
            }
        }
        #endregion

        private void wynnir_Load(object sender, EventArgs e)
        {

        }
    }
}
