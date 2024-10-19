namespace Contacts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbperson = new ListBox();
            label1 = new Label();
            txtname = new TextBox();
            txtfamily = new TextBox();
            label2 = new Label();
            btnsave = new Button();
            SuspendLayout();
            // 
            // lbperson
            // 
            lbperson.FormattingEnabled = true;
            lbperson.Location = new Point(444, 37);
            lbperson.Name = "lbperson";
            lbperson.Size = new Size(411, 644);
            lbperson.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 74);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtname
            // 
            txtname.Location = new Point(39, 134);
            txtname.Name = "txtname";
            txtname.Size = new Size(385, 39);
            txtname.TabIndex = 2;
            // 
            // txtfamily
            // 
            txtfamily.Location = new Point(39, 285);
            txtfamily.Name = "txtfamily";
            txtfamily.Size = new Size(385, 39);
            txtfamily.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 225);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 3;
            label2.Text = "Family";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(224, 361);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(150, 46);
            btnsave.TabIndex = 5;
            btnsave.Text = "&Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 719);
            Controls.Add(btnsave);
            Controls.Add(txtfamily);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(lbperson);
            Name = "Form1";
            Text = "Contact List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbperson;
        private Label label1;
        private TextBox txtname;
        private TextBox txtfamily;
        private Label label2;
        private Button btnsave;
    }
}
