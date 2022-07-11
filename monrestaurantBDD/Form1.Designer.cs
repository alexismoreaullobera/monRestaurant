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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddFirstname = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddFirstname = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.groupBoxAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Controls.Add(this.btnAddClient);
            this.groupBoxAddClient.Controls.Add(this.textBoxAddFirstname);
            this.groupBoxAddClient.Controls.Add(this.textBoxAddName);
            this.groupBoxAddClient.Controls.Add(this.labelAddFirstname);
            this.groupBoxAddClient.Controls.Add(this.labelAddName);
            this.groupBoxAddClient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(314, 126);
            this.groupBoxAddClient.TabIndex = 1;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "Ajouter";
            this.groupBoxAddClient.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(44, 27);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(40, 15);
            this.labelAddName.TabIndex = 0;
            this.labelAddName.Text = "Nom :";
            this.labelAddName.Click += new System.EventHandler(this.label1_Click);
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
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(116, 24);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(181, 23);
            this.textBoxAddName.TabIndex = 2;
            // 
            // textBoxAddFirstname
            // 
            this.textBoxAddFirstname.Location = new System.Drawing.Point(116, 61);
            this.textBoxAddFirstname.Name = "textBoxAddFirstname";
            this.textBoxAddFirstname.Size = new System.Drawing.Size(181, 23);
            this.textBoxAddFirstname.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 704);
            this.Controls.Add(this.groupBoxAddClient);
            this.Controls.Add(this.button1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private GroupBox groupBoxAddClient;
        private Label labelAddFirstname;
        private Label labelAddName;
        private Button btnAddClient;
        private TextBox textBoxAddFirstname;
        private TextBox textBoxAddName;
    }
}