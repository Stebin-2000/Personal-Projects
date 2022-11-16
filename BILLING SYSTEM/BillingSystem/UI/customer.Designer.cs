namespace BillingSystem.UI
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcustsearch = new System.Windows.Forms.TextBox();
            this.txtcustcontact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustaddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvcust = new System.Windows.Forms.DataGridView();
            this.txtcustemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcustsearch
            // 
            this.txtcustsearch.Location = new System.Drawing.Point(734, 60);
            this.txtcustsearch.Name = "txtcustsearch";
            this.txtcustsearch.Size = new System.Drawing.Size(326, 22);
            this.txtcustsearch.TabIndex = 92;
            this.txtcustsearch.TextChanged += new System.EventHandler(this.txtcustsearch_TextChanged);
            // 
            // txtcustcontact
            // 
            this.txtcustcontact.Location = new System.Drawing.Point(138, 383);
            this.txtcustcontact.Multiline = true;
            this.txtcustcontact.Name = "txtcustcontact";
            this.txtcustcontact.Size = new System.Drawing.Size(181, 22);
            this.txtcustcontact.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "CONTACT NO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 49);
            this.button3.TabIndex = 89;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 49);
            this.button2.TabIndex = 88;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 49);
            this.button1.TabIndex = 87;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "SEARCH";
            // 
            // txtcustid
            // 
            this.txtcustid.Location = new System.Drawing.Point(138, 95);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.ReadOnly = true;
            this.txtcustid.Size = new System.Drawing.Size(181, 22);
            this.txtcustid.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "ID";
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(138, 163);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(181, 22);
            this.txtcustname.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "NAME";
            // 
            // txtcustaddress
            // 
            this.txtcustaddress.Location = new System.Drawing.Point(138, 239);
            this.txtcustaddress.Multiline = true;
            this.txtcustaddress.Name = "txtcustaddress";
            this.txtcustaddress.Size = new System.Drawing.Size(181, 92);
            this.txtcustaddress.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 44);
            this.panel1.TabIndex = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1017, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvcust
            // 
            this.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcust.Location = new System.Drawing.Point(354, 95);
            this.dgvcust.Name = "dgvcust";
            this.dgvcust.RowHeadersWidth = 51;
            this.dgvcust.RowTemplate.Height = 24;
            this.dgvcust.Size = new System.Drawing.Size(706, 373);
            this.dgvcust.TabIndex = 85;
            this.dgvcust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcust_RowHeaderMouseClick);
            // 
            // txtcustemail
            // 
            this.txtcustemail.Location = new System.Drawing.Point(138, 446);
            this.txtcustemail.Multiline = true;
            this.txtcustemail.Name = "txtcustemail";
            this.txtcustemail.Size = new System.Drawing.Size(181, 22);
            this.txtcustemail.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "EMAIL ID";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1072, 568);
            this.Controls.Add(this.txtcustemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcustsearch);
            this.Controls.Add(this.txtcustcontact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcustaddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvcust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUSTOMERS";
            this.Load += new System.EventHandler(this.customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcustsearch;
        private System.Windows.Forms.TextBox txtcustcontact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcustaddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvcust;
        private System.Windows.Forms.TextBox txtcustemail;
        private System.Windows.Forms.Label label4;
    }
}