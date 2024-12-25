using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }
            Data data = new Data();

        private void ResetPass_Load(object sender, EventArgs e)
        {
            
            cbbUser.Items.Clear();


            //tao list de chua user tu database
            List<string> user = new List<string>();
            data.Loaduser(user);  // Goi ham Loaduser tu class Data
            user.Sort();
            //sap xep user theo thu tu abc
            foreach (string s in user)
            {
                cbbUser.Items.Add(s);
            }
            if (cbbUser.Items.Count > 0)
            {
                cbbUser.SelectedIndex = 0;
            }

        }
    }
}
