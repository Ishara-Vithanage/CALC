namespace dotnet_winforms
{
    partial class PopupForm
    {
        private CheckBox chkAddFooter;
        private RichTextBox txtFooterContent;
        private Button btnOk;
        private Button btnCancel;

        private void InitializeComponent()
        {
            this.chkAddFooter = new CheckBox();
            this.txtFooterContent = new RichTextBox();
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // 
            // chkAddFooter
            // 
            this.chkAddFooter.AutoSize = true;
            this.chkAddFooter.Location = new System.Drawing.Point(20, 20);
            this.chkAddFooter.Name = "chkAddFooter";
            this.chkAddFooter.Size = new System.Drawing.Size(100, 21);
            this.chkAddFooter.TabIndex = 0;
            this.chkAddFooter.Text = "Add Footer";
            this.chkAddFooter.UseVisualStyleBackColor = true;
            this.chkAddFooter.CheckedChanged += new EventHandler(this.chkAddFooter_CheckedChanged);

            // 
            // txtFooterContent
            // 
            this.txtFooterContent.Location = new System.Drawing.Point(20, 50);
            this.txtFooterContent.Name = "txtFooterContent";
            this.txtFooterContent.Size = new System.Drawing.Size(250, 100);
            this.txtFooterContent.TabIndex = 1;
            this.txtFooterContent.Enabled = false;

            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(20, 160);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new EventHandler(this.btnOk_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.chkAddFooter);
            this.Controls.Add(this.txtFooterContent);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "PopupForm";
            this.Text = "Popup Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
