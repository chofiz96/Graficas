namespace Graph
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
            this.cB_Data = new System.Windows.Forms.ComboBox();
            this.cB_Factory = new System.Windows.Forms.ComboBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_Data
            // 
            this.cB_Data.FormattingEnabled = true;
            this.cB_Data.Location = new System.Drawing.Point(108, 12);
            this.cB_Data.Name = "cB_Data";
            this.cB_Data.Size = new System.Drawing.Size(201, 21);
            this.cB_Data.TabIndex = 0;
            this.cB_Data.SelectedIndexChanged += new System.EventHandler(this.cB_Data_SelectedIndexChanged);
            // 
            // cB_Factory
            // 
            this.cB_Factory.FormattingEnabled = true;
            this.cB_Factory.Location = new System.Drawing.Point(108, 51);
            this.cB_Factory.Name = "cB_Factory";
            this.cB_Factory.Size = new System.Drawing.Size(201, 21);
            this.cB_Factory.TabIndex = 1;
            this.cB_Factory.SelectedIndexChanged += new System.EventHandler(this.cB_Factory_SelectedIndexChanged);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(154, 91);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Text = "OK";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.cB_Factory);
            this.Controls.Add(this.cB_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Data;
        private System.Windows.Forms.ComboBox cB_Factory;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

