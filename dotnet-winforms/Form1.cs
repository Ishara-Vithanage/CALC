using System;
using System.Windows.Forms;

namespace dotnet_winforms
{
    public partial class Form1 : Form
    {
        // Variables to hold the state of the popup form
        public bool IsFooterEnabled { get; set; }
        public string FooterContent { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPopup_Click(object sender, EventArgs e)
        {
            // Open the popup form
            using (PopupForm popup = new PopupForm(IsFooterEnabled, FooterContent))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    // Save the updated values from the popup
                    IsFooterEnabled = popup.IsFooterEnabled;
                    FooterContent = popup.FooterContent;
                }
            }
        }
    }
}
