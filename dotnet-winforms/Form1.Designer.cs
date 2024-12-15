namespace dotnet_winforms
{
    partial class Form1
    {
        private Button btnShowPopup;

        private void InitializeComponent()
        {
            this.btnShowPopup = new Button();
            this.SuspendLayout();

            // 
            // btnShowPopup
            // 
            this.btnShowPopup.Location = new System.Drawing.Point(50, 50);
            this.btnShowPopup.Name = "btnShowPopup";
            this.btnShowPopup.Size = new System.Drawing.Size(150, 50);
            this.btnShowPopup.TabIndex = 0;
            this.btnShowPopup.Text = "Show Popup";
            this.btnShowPopup.UseVisualStyleBackColor = true;
            this.btnShowPopup.Click += new EventHandler(this.btnShowPopup_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.btnShowPopup);
            this.Name = "Form1";
            this.Text = "Parent Form";
            this.ResumeLayout(false);
        }
    }
}
