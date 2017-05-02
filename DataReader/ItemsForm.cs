using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReader
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Collections.Items;
        }
    }
}
