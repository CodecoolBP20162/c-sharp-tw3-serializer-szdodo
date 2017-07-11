namespace Serializer
{
    partial class PersonForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.firstBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serialNumbLbl = new System.Windows.Forms.Label();
            this.serNumbTxtLbl = new System.Windows.Forms.Label();
            this.DORTxtLbl = new System.Windows.Forms.Label();
            this.DORLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLbl.Location = new System.Drawing.Point(20, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressLbl.Location = new System.Drawing.Point(23, 61);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(64, 17);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Address:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneLbl.Location = new System.Drawing.Point(20, 118);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(111, 17);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = " Phone Number:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(23, 29);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(189, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(23, 81);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(189, 20);
            this.addressTxt.TabIndex = 4;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(23, 138);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(189, 20);
            this.phoneTxt.TabIndex = 5;
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevBtn.Location = new System.Drawing.Point(102, 290);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(78, 32);
            this.prevBtn.TabIndex = 6;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextBtn.Location = new System.Drawing.Point(299, 290);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(77, 32);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // firstBtn
            // 
            this.firstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstBtn.Location = new System.Drawing.Point(12, 290);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(75, 32);
            this.firstBtn.TabIndex = 8;
            this.firstBtn.Text = "First";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastBtn.Location = new System.Drawing.Point(399, 290);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(76, 32);
            this.lastBtn.TabIndex = 9;
            this.lastBtn.Text = "Last";
            this.lastBtn.UseVisualStyleBackColor = true;
            this.lastBtn.Click += new System.EventHandler(this.LastBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.Location = new System.Drawing.Point(200, 290);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 32);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // serialNumbLbl
            // 
            this.serialNumbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serialNumbLbl.Location = new System.Drawing.Point(150, 193);
            this.serialNumbLbl.Name = "serialNumbLbl";
            this.serialNumbLbl.Size = new System.Drawing.Size(39, 26);
            this.serialNumbLbl.TabIndex = 11;
            // 
            // serNumbTxtLbl
            // 
            this.serNumbTxtLbl.AutoSize = true;
            this.serNumbTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serNumbTxtLbl.Location = new System.Drawing.Point(20, 193);
            this.serNumbTxtLbl.Name = "serNumbTxtLbl";
            this.serNumbTxtLbl.Size = new System.Drawing.Size(102, 17);
            this.serNumbTxtLbl.TabIndex = 12;
            this.serNumbTxtLbl.Text = "Serial Number:";
            // 
            // DORTxtLbl
            // 
            this.DORTxtLbl.AutoSize = true;
            this.DORTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DORTxtLbl.Location = new System.Drawing.Point(20, 234);
            this.DORTxtLbl.Name = "DORTxtLbl";
            this.DORTxtLbl.Size = new System.Drawing.Size(127, 17);
            this.DORTxtLbl.TabIndex = 13;
            this.DORTxtLbl.Text = "Date of Recodring:";
            // 
            // DORLbl
            // 
            this.DORLbl.AutoSize = true;
            this.DORLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DORLbl.Location = new System.Drawing.Point(164, 234);
            this.DORLbl.Name = "DORLbl";
            this.DORLbl.Size = new System.Drawing.Size(0, 17);
            this.DORLbl.TabIndex = 14;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 334);
            this.Controls.Add(this.DORLbl);
            this.Controls.Add(this.DORTxtLbl);
            this.Controls.Add(this.serNumbTxtLbl);
            this.Controls.Add(this.serialNumbLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "PersonForm";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label serialNumbLbl;
        private System.Windows.Forms.Label serNumbTxtLbl;
        private System.Windows.Forms.Label DORTxtLbl;
        private System.Windows.Forms.Label DORLbl;
    }
}

