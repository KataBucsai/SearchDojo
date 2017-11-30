using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDojo
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            var results = PatternSearcher.Search(textBoxInputText.Text, textBoxPattern.Text);
            foreach (var result in results)
            {
                textBoxMatched.Text += result + "\r\n";
            }
        }

        private void validate_search_input(object sender, System.EventArgs e)
        {
            if (textBoxInputText.Text.Length > 0 && textBoxPattern.Text.Length > 0)
            {
                btnSearch.Enabled = true;
                btnSearch.ForeColor = Color.Black;
            } else
            {
                btnSearch.Enabled = false;
                btnSearch.ForeColor = Color.Gray;
            }
        }
    }
}
