
namespace UserMaintenance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_User = new System.Windows.Forms.ListBox();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.text_FirstName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_User
            // 
            this.list_User.FormattingEnabled = true;
            this.list_User.ItemHeight = 20;
            this.list_User.Location = new System.Drawing.Point(30, 36);
            this.list_User.Name = "list_User";
            this.list_User.Size = new System.Drawing.Size(298, 384);
            this.list_User.TabIndex = 0;
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(468, 51);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(270, 26);
            this.text_LastName.TabIndex = 1;
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(468, 130);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(270, 26);
            this.text_FirstName.TabIndex = 2;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(398, 209);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(340, 53);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "button1";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(374, 57);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(51, 20);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "label1";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(374, 136);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(51, 20);
            this.label_FirstName.TabIndex = 5;
            this.label_FirstName.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.text_FirstName);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.list_User);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_User;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.TextBox text_FirstName;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
    }
}

