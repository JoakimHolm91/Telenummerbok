
namespace Telenummerbok
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
            this.listPersonsBtn = new System.Windows.Forms.Button();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.removePersonBtn = new System.Windows.Forms.Button();
            this.phonebookListBox = new System.Windows.Forms.ListBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPersonsBtn
            // 
            this.listPersonsBtn.Location = new System.Drawing.Point(500, 47);
            this.listPersonsBtn.Name = "listPersonsBtn";
            this.listPersonsBtn.Size = new System.Drawing.Size(114, 23);
            this.listPersonsBtn.TabIndex = 4;
            this.listPersonsBtn.Text = "Lista alla personer";
            this.listPersonsBtn.UseVisualStyleBackColor = true;
            this.listPersonsBtn.Click += new System.EventHandler(this.listPersonsBtn_Click);
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(327, 296);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(114, 23);
            this.addPersonBtn.TabIndex = 3;
            this.addPersonBtn.Text = "Lägg till person";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // removePersonBtn
            // 
            this.removePersonBtn.Location = new System.Drawing.Point(500, 404);
            this.removePersonBtn.Name = "removePersonBtn";
            this.removePersonBtn.Size = new System.Drawing.Size(114, 23);
            this.removePersonBtn.TabIndex = 5;
            this.removePersonBtn.Text = "Ta bort person";
            this.removePersonBtn.UseVisualStyleBackColor = true;
            this.removePersonBtn.Click += new System.EventHandler(this.removePersonBtn_Click);
            // 
            // phonebookListBox
            // 
            this.phonebookListBox.FormattingEnabled = true;
            this.phonebookListBox.Location = new System.Drawing.Point(500, 86);
            this.phonebookListBox.Name = "phonebookListBox";
            this.phonebookListBox.Size = new System.Drawing.Size(288, 303);
            this.phonebookListBox.TabIndex = 7;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Location = new System.Drawing.Point(240, 182);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Förnamn:";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(307, 179);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(144, 20);
            this.firstNameTxt.TabIndex = 0;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(307, 217);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(144, 20);
            this.lastNameTxt.TabIndex = 1;
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(307, 254);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(144, 20);
            this.numberTxt.TabIndex = 2;
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLbl.Location = new System.Drawing.Point(242, 257);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(49, 13);
            this.phoneNumberLbl.TabIndex = 8;
            this.phoneNumberLbl.Text = "Nummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(240, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Efternamn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.phonebookListBox);
            this.Controls.Add(this.removePersonBtn);
            this.Controls.Add(this.addPersonBtn);
            this.Controls.Add(this.listPersonsBtn);
            this.Name = "Form1";
            this.Text = "Telefonnummerbok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listPersonsBtn;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.Button removePersonBtn;
        private System.Windows.Forms.ListBox phonebookListBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label label1;
    }
}

