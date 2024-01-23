using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using tools;

namespace Pub_Sub_Client
{
    public partial class Form1 : Form
    {
        Mqtt client;

        public Form1()
        {
            InitializeComponent();
            client = new Mqtt();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            client.publish("sdfdsfds"); 
        }
    }
}
