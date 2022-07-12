namespace monrestaurantBDD
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.textBoxAddFirstname = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.labelAddFirstname = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBoxAddClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(984, 655);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(156, 37);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click_1);
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Controls.Add(this.btnAddClient);
            this.groupBoxAddClient.Controls.Add(this.textBoxAddFirstname);
            this.groupBoxAddClient.Controls.Add(this.textBoxAddName);
            this.groupBoxAddClient.Controls.Add(this.labelAddFirstname);
            this.groupBoxAddClient.Controls.Add(this.labelAddName);
            this.groupBoxAddClient.Location = new System.Drawing.Point(27, 28);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(314, 126);
            this.groupBoxAddClient.TabIndex = 1;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "Ajouter";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(96, 97);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(122, 23);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Ajouter client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // textBoxAddFirstname
            // 
            this.textBoxAddFirstname.Location = new System.Drawing.Point(116, 61);
            this.textBoxAddFirstname.Name = "textBoxAddFirstname";
            this.textBoxAddFirstname.Size = new System.Drawing.Size(181, 23);
            this.textBoxAddFirstname.TabIndex = 3;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(116, 24);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(181, 23);
            this.textBoxAddName.TabIndex = 2;
            // 
            // labelAddFirstname
            // 
            this.labelAddFirstname.AutoSize = true;
            this.labelAddFirstname.Location = new System.Drawing.Point(29, 69);
            this.labelAddFirstname.Name = "labelAddFirstname";
            this.labelAddFirstname.Size = new System.Drawing.Size(55, 15);
            this.labelAddFirstname.TabIndex = 1;
            this.labelAddFirstname.Text = "Prénom :";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(44, 27);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(40, 15);
            this.labelAddName.TabIndex = 0;
            this.labelAddName.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 484);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des clients";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(6, 22);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(366, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Actualiser la liste";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(7, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 427);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prénom";
            this.columnHeader3.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAddClient);
            this.Controls.Add(this.btnConnection);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConnection;
        private GroupBox groupBoxAddClient;
        private Label labelAddFirstname;
        private Label labelAddName;
        private Button btnAddClient;
        private TextBox textBoxAddFirstname;
        private TextBox textBoxAddName;
        private GroupBox groupBox1;
        private Button btnList;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}