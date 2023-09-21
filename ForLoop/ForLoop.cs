using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class ForLoop : Form
    {
        public ForLoop()
        {
            InitializeComponent();
        }

        private void ForLoop_Load(object sender, EventArgs e)
        {
            for(int i=1; i<10; i++)
            {
                lstNumbers.Items.Add(i);
            }

        }

        private void lstEvenNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectEvenNumber_Click(object sender, EventArgs e)
        {
            for (int i = lstNumbers.Items.Count -1; i >= 0; i--)                // -- yapmamızın nedeni yukarıdan başlayıp geriye gitmesi
            {
                int number = Convert.ToInt32(lstNumbers.Items[i]);
                if (number % 2 == 0)
                {
                    lstEvenNumbers.Items.Add(number);
                }
            }

        }
    }
}
