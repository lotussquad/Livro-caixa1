namespace Livro.View
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.datainicial = new System.Windows.Forms.DateTimePicker();
            this.datafinal = new System.Windows.Forms.DateTimePicker();
            this.printBtn = new System.Windows.Forms.Button();
            this.verBtn = new System.Windows.Forms.Button();
            this.data1lbl = new System.Windows.Forms.Label();
            this.data2lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datainicial
            // 
            this.datainicial.Location = new System.Drawing.Point(12, 72);
            this.datainicial.Name = "datainicial";
            this.datainicial.Size = new System.Drawing.Size(200, 20);
            this.datainicial.TabIndex = 29;
            // 
            // datafinal
            // 
            this.datafinal.Location = new System.Drawing.Point(327, 72);
            this.datafinal.Name = "datafinal";
            this.datafinal.Size = new System.Drawing.Size(200, 20);
            this.datafinal.TabIndex = 30;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(12, 135);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(214, 96);
            this.printBtn.TabIndex = 31;
            this.printBtn.Text = "IMPRIMIR";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // verBtn
            // 
            this.verBtn.Location = new System.Drawing.Point(313, 135);
            this.verBtn.Name = "verBtn";
            this.verBtn.Size = new System.Drawing.Size(214, 96);
            this.verBtn.TabIndex = 32;
            this.verBtn.Text = "VISUALIZAR";
            this.verBtn.UseVisualStyleBackColor = true;
            // 
            // data1lbl
            // 
            this.data1lbl.AutoSize = true;
            this.data1lbl.Location = new System.Drawing.Point(70, 56);
            this.data1lbl.Name = "data1lbl";
            this.data1lbl.Size = new System.Drawing.Size(79, 13);
            this.data1lbl.TabIndex = 33;
            this.data1lbl.Text = "DATA INICIAL:";
            this.data1lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // data2lbl
            // 
            this.data2lbl.AutoSize = true;
            this.data2lbl.Location = new System.Drawing.Point(389, 56);
            this.data2lbl.Name = "data2lbl";
            this.data2lbl.Size = new System.Drawing.Size(72, 13);
            this.data2lbl.TabIndex = 34;
            this.data2lbl.Text = "DATA FINAL:";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 258);
            this.Controls.Add(this.data2lbl);
            this.Controls.Add(this.data1lbl);
            this.Controls.Add(this.verBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.datafinal);
            this.Controls.Add(this.datainicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Print";
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datainicial;
        private System.Windows.Forms.DateTimePicker datafinal;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button verBtn;
        private System.Windows.Forms.Label data1lbl;
        private System.Windows.Forms.Label data2lbl;
    }
}