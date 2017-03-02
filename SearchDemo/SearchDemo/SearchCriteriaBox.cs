using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDemo
{
    public partial class SearchCriteriaBox : UserControl
    {
        public event EventHandler RemoveClicked;
        public object SelectedProperty
        {
            get
            {
                return cmbProperty.SelectedItem;
            }
        }

        public object SelectedCriteria
        {
            get
            {
                return cmbCriteria.SelectedItem;
            }
        }

        public string SelectedValue
        {
            get
            {
                return txtSearchValue.Text;
            }
        }

        public SearchCriteriaBox()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this,e);
        }
    }
}
