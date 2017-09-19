using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void dryckerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dryckerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drinksDataSet);

        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drinksDataSet.Drycker' table. You can move, or remove it, as needed.
            this.dryckerTableAdapter.Fill(this.drinksDataSet.Drycker);

        }
    }
}
