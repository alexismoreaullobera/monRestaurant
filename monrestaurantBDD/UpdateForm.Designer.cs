namespace monrestaurantBDD
{
    partial class UpdateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxModifier3 = new System.Windows.Forms.TextBox();
            this.textBoxModifier2 = new System.Windows.Forms.TextBox();
            this.textBoxModifier1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxModifier3);
            this.groupBox1.Controls.Add(this.textBoxModifier2);
            this.groupBox1.Controls.Add(this.textBoxModifier1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier les informations";
            // 
            // textBoxModifier3
            // 
            this.textBoxModifier3.Location = new System.Drawing.Point(158, 164);
            this.textBoxModifier3.Name = "textBoxModifier3";
            this.textBoxModifier3.Size = new System.Drawing.Size(185, 23);
            this.textBoxModifier3.TabIndex = 5;
            // 
            // textBoxModifier2
            // 
            this.textBoxModifier2.Location = new System.Drawing.Point(158, 117);
            this.textBoxModifier2.Name = "textBoxModifier2";
            this.textBoxModifier2.Size = new System.Drawing.Size(185, 23);
            this.textBoxModifier2.TabIndex = 4;
            // 
            // textBoxModifier1
            // 
            this.textBoxModifier1.Location = new System.Drawing.Point(158, 72);
            this.textBoxModifier1.Name = "textBoxModifier1";
            this.textBoxModifier1.Size = new System.Drawing.Size(185, 23);
            this.textBoxModifier1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(85, 279);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(290, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 332);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateForm";
            this.Text = "Modifier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxModifier3;
        private TextBox textBoxModifier2;
        private TextBox textBoxModifier1;
        private Label label3;
        private Label label2;
        private Button btnModifier;
    }
}