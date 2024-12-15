using System;
using System.Windows.Forms;

namespace dotnet_winforms
{
    public partial class PopupForm : Form
    {
        public bool IsFooterEnabled { get; private set; }
        public string FooterContent { get; private set; }

        public PopupForm(bool isFooterEnabled, string footerContent)
        {
            InitializeComponent();

            // Load the initial state
            chkAddFooter.Checked = isFooterEnabled;
            txtFooterContent.Text = footerContent;
            txtFooterContent.Enabled = isFooterEnabled;
        }

        private void chkAddFooter_CheckedChanged(object sender, EventArgs e)
        {
            txtFooterContent.Enabled = chkAddFooter.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IsFooterEnabled = chkAddFooter.Checked;
            FooterContent = txtFooterContent.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
