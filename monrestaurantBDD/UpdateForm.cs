using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monrestaurantBDD
{
    public partial class UpdateForm : Form
    {

        public String id
        {
            get { return textBoxModifier1.Text; }
            set { textBoxModifier1.Text = value; }
        }
        public String nom
        {
            get { return textBoxModifier2.Text; }
            set { textBoxModifier2.Text = value; }
        }
        public String prenom
        {
            get { return textBoxModifier3.Text; }
            set { textBoxModifier3.Text = value; }
        }




        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }


    }
}
