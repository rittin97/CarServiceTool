namespace lab2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.txtboxYear = new System.Windows.Forms.TextBox();
            this.txtboxLicense = new System.Windows.Forms.TextBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnServiceDate = new System.Windows.Forms.Button();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtboxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxMonth = new System.Windows.Forms.TextBox();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightGray;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(22, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(375, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter the required vehicle information:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Tan;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(83, 87);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(113, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model Name:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Tan;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(144, 123);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.BackColor = System.Drawing.Color.Tan;
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(120, 158);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(76, 20);
            this.lblLicense.TabIndex = 3;
            this.lblLicense.Text = "License:";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Tan;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 196);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(184, 41);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date of current service(MM/dd/yyyy):";
            // 
            // txtboxModel
            // 
            this.txtboxModel.Location = new System.Drawing.Point(271, 87);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(180, 20);
            this.txtboxModel.TabIndex = 5;
            // 
            // txtboxYear
            // 
            this.txtboxYear.Location = new System.Drawing.Point(271, 123);
            this.txtboxYear.Name = "txtboxYear";
            this.txtboxYear.Size = new System.Drawing.Size(180, 20);
            this.txtboxYear.TabIndex = 6;
            // 
            // txtboxLicense
            // 
            this.txtboxLicense.Location = new System.Drawing.Point(271, 158);
            this.txtboxLicense.Name = "txtboxLicense";
            this.txtboxLicense.Size = new System.Drawing.Size(180, 20);
            this.txtboxLicense.TabIndex = 7;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(271, 198);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(180, 20);
            this.txtboxDate.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(490, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(27, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 53);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to Database";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(218, 314);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 53);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Clear";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(445, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 53);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnServiceDate
            // 
            this.btnServiceDate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDate.Location = new System.Drawing.Point(218, 402);
            this.btnServiceDate.Name = "btnServiceDate";
            this.btnServiceDate.Size = new System.Drawing.Size(125, 53);
            this.btnServiceDate.TabIndex = 13;
            this.btnServiceDate.Text = "Get Service Date";
            this.btnServiceDate.UseVisualStyleBackColor = false;
            this.btnServiceDate.Click += new System.EventHandler(this.btnServiceDate_Click);
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.BackColor = System.Drawing.Color.PeachPuff;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.Location = new System.Drawing.Point(407, 330);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(0, 20);
            this.lblExample.TabIndex = 14;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDescription.Location = new System.Drawing.Point(48, 493);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(349, 152);
            this.txtboxDescription.TabIndex = 15;
            this.txtboxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of months between 2 services:";
            // 
            // txtboxMonth
            // 
            this.txtboxMonth.Location = new System.Drawing.Point(271, 255);
            this.txtboxMonth.Name = "txtboxMonth";
            this.txtboxMonth.Size = new System.Drawing.Size(180, 20);
            this.txtboxMonth.TabIndex = 17;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(490, 193);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(125, 27);
            this.btnSearchDate.TabIndex = 18;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "To search enter next service date(MM/dd/yyyy):";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "<---";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "<---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(627, 691);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.txtboxMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.btnServiceDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxLicense);
            this.Controls.Add(this.txtboxYear);
            this.Controls.Add(this.txtboxModel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Vehicle Service Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.TextBox txtboxYear;
        private System.Windows.Forms.TextBox txtboxLicense;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnServiceDate;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.RichTextBox txtboxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxMonth;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

