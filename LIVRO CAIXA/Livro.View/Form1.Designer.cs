﻿namespace Livro.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabInserir = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.datecalendarinsert = new System.Windows.Forms.DateTimePicker();
            this.despesaslblinsert = new System.Windows.Forms.Label();
            this.receitalblinsert = new System.Windows.Forms.Label();
            this.eventlblinsert = new System.Windows.Forms.Label();
            this.datelblinsert = new System.Windows.Forms.Label();
            this.receitasinsertTxt = new System.Windows.Forms.TextBox();
            this.despesasinsertTxt = new System.Windows.Forms.TextBox();
            this.eventinsertTxt = new System.Windows.Forms.TextBox();
            this.TabDelete = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.iddeletelbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.iddeleteTxt = new System.Windows.Forms.TextBox();
            this.TabUpdate = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.idupdatelbl = new System.Windows.Forms.Label();
            this.idupdateTxt = new System.Windows.Forms.TextBox();
            this.datecalendarupdate = new System.Windows.Forms.DateTimePicker();
            this.despesaslblupdate = new System.Windows.Forms.Label();
            this.receitaslblupdate = new System.Windows.Forms.Label();
            this.eventlblupdate = new System.Windows.Forms.Label();
            this.datelblupdate = new System.Windows.Forms.Label();
            this.receitasupdateTxt = new System.Windows.Forms.TextBox();
            this.despesasupdateTxt = new System.Windows.Forms.TextBox();
            this.eventupdateTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.TabSelect = new System.Windows.Forms.TabPage();
            this.txtFolhaPrinter = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.selectImpressora = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.srcBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datesrclbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.TabControl.SuspendLayout();
            this.TabInserir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.TabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TabSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabInserir);
            this.TabControl.Controls.Add(this.TabDelete);
            this.TabControl.Controls.Add(this.TabUpdate);
            this.TabControl.Controls.Add(this.TabSelect);
            this.TabControl.Location = new System.Drawing.Point(-1, -2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(685, 381);
            this.TabControl.TabIndex = 0;
            // 
            // TabInserir
            // 
            this.TabInserir.BackColor = System.Drawing.Color.White;
            this.TabInserir.Controls.Add(this.label1);
            this.TabInserir.Controls.Add(this.insertBtn);
            this.TabInserir.Controls.Add(this.label4);
            this.TabInserir.Controls.Add(this.pictureBox4);
            this.TabInserir.Controls.Add(this.datecalendarinsert);
            this.TabInserir.Controls.Add(this.despesaslblinsert);
            this.TabInserir.Controls.Add(this.receitalblinsert);
            this.TabInserir.Controls.Add(this.eventlblinsert);
            this.TabInserir.Controls.Add(this.datelblinsert);
            this.TabInserir.Controls.Add(this.receitasinsertTxt);
            this.TabInserir.Controls.Add(this.despesasinsertTxt);
            this.TabInserir.Controls.Add(this.eventinsertTxt);
            this.TabInserir.Location = new System.Drawing.Point(4, 22);
            this.TabInserir.Name = "TabInserir";
            this.TabInserir.Padding = new System.Windows.Forms.Padding(3);
            this.TabInserir.Size = new System.Drawing.Size(677, 355);
            this.TabInserir.TabIndex = 0;
            this.TabInserir.Text = "INSERIR ";
            this.TabInserir.Click += new System.EventHandler(this.TabInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(197, 259);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(282, 68);
            this.insertBtn.TabIndex = 36;
            this.insertBtn.Text = "INSERIR NO LIVRO";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(160, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "1° TABELIONATO DE NOTAS DE CAMPO LARGO";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Livro.View.Properties.Resources.republica_brasao_cinza_cmyk;
            this.pictureBox4.Location = new System.Drawing.Point(8, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // datecalendarinsert
            // 
            this.datecalendarinsert.Location = new System.Drawing.Point(90, 118);
            this.datecalendarinsert.Name = "datecalendarinsert";
            this.datecalendarinsert.Size = new System.Drawing.Size(227, 20);
            this.datecalendarinsert.TabIndex = 14;
            // 
            // despesaslblinsert
            // 
            this.despesaslblinsert.AutoSize = true;
            this.despesaslblinsert.Location = new System.Drawing.Point(352, 184);
            this.despesaslblinsert.Name = "despesaslblinsert";
            this.despesaslblinsert.Size = new System.Drawing.Size(67, 13);
            this.despesaslblinsert.TabIndex = 12;
            this.despesaslblinsert.Text = "DESPESAS:";
            // 
            // receitalblinsert
            // 
            this.receitalblinsert.AutoSize = true;
            this.receitalblinsert.Location = new System.Drawing.Point(24, 184);
            this.receitalblinsert.Name = "receitalblinsert";
            this.receitalblinsert.Size = new System.Drawing.Size(63, 13);
            this.receitalblinsert.TabIndex = 11;
            this.receitalblinsert.Text = "RECEITAS:";
            // 
            // eventlblinsert
            // 
            this.eventlblinsert.AutoSize = true;
            this.eventlblinsert.Location = new System.Drawing.Point(365, 121);
            this.eventlblinsert.Name = "eventlblinsert";
            this.eventlblinsert.Size = new System.Drawing.Size(54, 13);
            this.eventlblinsert.TabIndex = 8;
            this.eventlblinsert.Text = "EVENTO:";
            // 
            // datelblinsert
            // 
            this.datelblinsert.AutoSize = true;
            this.datelblinsert.Location = new System.Drawing.Point(45, 121);
            this.datelblinsert.Name = "datelblinsert";
            this.datelblinsert.Size = new System.Drawing.Size(39, 13);
            this.datelblinsert.TabIndex = 7;
            this.datelblinsert.Text = "DATA:";
            // 
            // receitasinsertTxt
            // 
            this.receitasinsertTxt.Location = new System.Drawing.Point(90, 180);
            this.receitasinsertTxt.Name = "receitasinsertTxt";
            this.receitasinsertTxt.Size = new System.Drawing.Size(227, 20);
            this.receitasinsertTxt.TabIndex = 6;
            // 
            // despesasinsertTxt
            // 
            this.despesasinsertTxt.Location = new System.Drawing.Point(425, 180);
            this.despesasinsertTxt.Name = "despesasinsertTxt";
            this.despesasinsertTxt.Size = new System.Drawing.Size(209, 20);
            this.despesasinsertTxt.TabIndex = 4;
            this.despesasinsertTxt.TextChanged += new System.EventHandler(this.despesasinsertTxt_TextChanged);
            // 
            // eventinsertTxt
            // 
            this.eventinsertTxt.Location = new System.Drawing.Point(425, 118);
            this.eventinsertTxt.Name = "eventinsertTxt";
            this.eventinsertTxt.Size = new System.Drawing.Size(209, 20);
            this.eventinsertTxt.TabIndex = 2;
            // 
            // TabDelete
            // 
            this.TabDelete.BackColor = System.Drawing.Color.White;
            this.TabDelete.Controls.Add(this.pictureBox3);
            this.TabDelete.Controls.Add(this.iddeletelbl);
            this.TabDelete.Controls.Add(this.deleteBtn);
            this.TabDelete.Controls.Add(this.iddeleteTxt);
            this.TabDelete.Location = new System.Drawing.Point(4, 22);
            this.TabDelete.Name = "TabDelete";
            this.TabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TabDelete.Size = new System.Drawing.Size(677, 355);
            this.TabDelete.TabIndex = 1;
            this.TabDelete.Text = "EXCLUIR";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Livro.View.Properties.Resources.republica_brasao_cinza_cmyk;
            this.pictureBox3.Location = new System.Drawing.Point(8, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // iddeletelbl
            // 
            this.iddeletelbl.AutoSize = true;
            this.iddeletelbl.Location = new System.Drawing.Point(337, 123);
            this.iddeletelbl.Name = "iddeletelbl";
            this.iddeletelbl.Size = new System.Drawing.Size(21, 13);
            this.iddeletelbl.TabIndex = 2;
            this.iddeletelbl.Text = "ID:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(238, 180);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(205, 90);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "DELETAR";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deletBtn_Click);
            // 
            // iddeleteTxt
            // 
            this.iddeleteTxt.Location = new System.Drawing.Point(175, 139);
            this.iddeleteTxt.Name = "iddeleteTxt";
            this.iddeleteTxt.Size = new System.Drawing.Size(339, 20);
            this.iddeleteTxt.TabIndex = 0;
            // 
            // TabUpdate
            // 
            this.TabUpdate.BackColor = System.Drawing.Color.White;
            this.TabUpdate.Controls.Add(this.label3);
            this.TabUpdate.Controls.Add(this.pictureBox2);
            this.TabUpdate.Controls.Add(this.idupdatelbl);
            this.TabUpdate.Controls.Add(this.idupdateTxt);
            this.TabUpdate.Controls.Add(this.datecalendarupdate);
            this.TabUpdate.Controls.Add(this.despesaslblupdate);
            this.TabUpdate.Controls.Add(this.receitaslblupdate);
            this.TabUpdate.Controls.Add(this.eventlblupdate);
            this.TabUpdate.Controls.Add(this.datelblupdate);
            this.TabUpdate.Controls.Add(this.receitasupdateTxt);
            this.TabUpdate.Controls.Add(this.despesasupdateTxt);
            this.TabUpdate.Controls.Add(this.eventupdateTxt);
            this.TabUpdate.Controls.Add(this.updateBtn);
            this.TabUpdate.Location = new System.Drawing.Point(4, 22);
            this.TabUpdate.Name = "TabUpdate";
            this.TabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.TabUpdate.Size = new System.Drawing.Size(677, 355);
            this.TabUpdate.TabIndex = 2;
            this.TabUpdate.Text = "EDITAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(160, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "1° TABELIONATO DE NOTAS DE CAMPO LARGO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Livro.View.Properties.Resources.republica_brasao_cinza_cmyk;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // idupdatelbl
            // 
            this.idupdatelbl.AutoSize = true;
            this.idupdatelbl.Location = new System.Drawing.Point(331, 205);
            this.idupdatelbl.Name = "idupdatelbl";
            this.idupdatelbl.Size = new System.Drawing.Size(21, 13);
            this.idupdatelbl.TabIndex = 29;
            this.idupdatelbl.Text = "ID:";
            // 
            // idupdateTxt
            // 
            this.idupdateTxt.Location = new System.Drawing.Point(263, 221);
            this.idupdateTxt.Name = "idupdateTxt";
            this.idupdateTxt.Size = new System.Drawing.Size(173, 20);
            this.idupdateTxt.TabIndex = 28;
            // 
            // datecalendarupdate
            // 
            this.datecalendarupdate.Location = new System.Drawing.Point(79, 104);
            this.datecalendarupdate.Name = "datecalendarupdate";
            this.datecalendarupdate.Size = new System.Drawing.Size(200, 20);
            this.datecalendarupdate.TabIndex = 27;
            // 
            // despesaslblupdate
            // 
            this.despesaslblupdate.AutoSize = true;
            this.despesaslblupdate.Location = new System.Drawing.Point(377, 161);
            this.despesaslblupdate.Name = "despesaslblupdate";
            this.despesaslblupdate.Size = new System.Drawing.Size(67, 13);
            this.despesaslblupdate.TabIndex = 26;
            this.despesaslblupdate.Text = "DESPESAS:";
            // 
            // receitaslblupdate
            // 
            this.receitaslblupdate.AutoSize = true;
            this.receitaslblupdate.Location = new System.Drawing.Point(10, 163);
            this.receitaslblupdate.Name = "receitaslblupdate";
            this.receitaslblupdate.Size = new System.Drawing.Size(63, 13);
            this.receitaslblupdate.TabIndex = 25;
            this.receitaslblupdate.Text = "RECEITAS:";
            // 
            // eventlblupdate
            // 
            this.eventlblupdate.AutoSize = true;
            this.eventlblupdate.Location = new System.Drawing.Point(390, 104);
            this.eventlblupdate.Name = "eventlblupdate";
            this.eventlblupdate.Size = new System.Drawing.Size(54, 13);
            this.eventlblupdate.TabIndex = 22;
            this.eventlblupdate.Text = "EVENTO:";
            // 
            // datelblupdate
            // 
            this.datelblupdate.AutoSize = true;
            this.datelblupdate.Location = new System.Drawing.Point(34, 104);
            this.datelblupdate.Name = "datelblupdate";
            this.datelblupdate.Size = new System.Drawing.Size(39, 13);
            this.datelblupdate.TabIndex = 21;
            this.datelblupdate.Text = "DATA:";
            // 
            // receitasupdateTxt
            // 
            this.receitasupdateTxt.Location = new System.Drawing.Point(79, 158);
            this.receitasupdateTxt.Name = "receitasupdateTxt";
            this.receitasupdateTxt.Size = new System.Drawing.Size(173, 20);
            this.receitasupdateTxt.TabIndex = 20;
            // 
            // despesasupdateTxt
            // 
            this.despesasupdateTxt.Location = new System.Drawing.Point(450, 158);
            this.despesasupdateTxt.Name = "despesasupdateTxt";
            this.despesasupdateTxt.Size = new System.Drawing.Size(173, 20);
            this.despesasupdateTxt.TabIndex = 18;
            // 
            // eventupdateTxt
            // 
            this.eventupdateTxt.Location = new System.Drawing.Point(450, 101);
            this.eventupdateTxt.Name = "eventupdateTxt";
            this.eventupdateTxt.Size = new System.Drawing.Size(173, 20);
            this.eventupdateTxt.TabIndex = 16;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(206, 275);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(282, 68);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "EDITAR NO LIVRO";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // TabSelect
            // 
            this.TabSelect.BackColor = System.Drawing.Color.White;
            this.TabSelect.Controls.Add(this.txtFolhaPrinter);
            this.TabSelect.Controls.Add(this.btnPrint);
            this.TabSelect.Controls.Add(this.label6);
            this.TabSelect.Controls.Add(this.selectImpressora);
            this.TabSelect.Controls.Add(this.button1);
            this.TabSelect.Controls.Add(this.label5);
            this.TabSelect.Controls.Add(this.dateTimePicker1);
            this.TabSelect.Controls.Add(this.srcBtn);
            this.TabSelect.Controls.Add(this.label2);
            this.TabSelect.Controls.Add(this.pictureBox1);
            this.TabSelect.Controls.Add(this.datesrclbl);
            this.TabSelect.Controls.Add(this.dataGridView1);
            this.TabSelect.Location = new System.Drawing.Point(4, 22);
            this.TabSelect.Name = "TabSelect";
            this.TabSelect.Padding = new System.Windows.Forms.Padding(3);
            this.TabSelect.Size = new System.Drawing.Size(677, 355);
            this.TabSelect.TabIndex = 3;
            this.TabSelect.Text = "RELATÓRIO";
            // 
            // txtFolhaPrinter
            // 
            this.txtFolhaPrinter.Location = new System.Drawing.Point(573, 272);
            this.txtFolhaPrinter.Name = "txtFolhaPrinter";
            this.txtFolhaPrinter.Size = new System.Drawing.Size(60, 20);
            this.txtFolhaPrinter.TabIndex = 46;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(566, 307);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "IMPRIMIR";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "IMPRESSORA:";
            // 
            // selectImpressora
            // 
            this.selectImpressora.FormattingEnabled = true;
            this.selectImpressora.Location = new System.Drawing.Point(409, 288);
            this.selectImpressora.Name = "selectImpressora";
            this.selectImpressora.Size = new System.Drawing.Size(121, 21);
            this.selectImpressora.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "BUSCA POR DATA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(52, 296);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(75, 23);
            this.srcBtn.TabIndex = 35;
            this.srcBtn.Text = "BUSCAR";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(160, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "1° TABELIONATO DE NOTAS DE CAMPO LARGO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Livro.View.Properties.Resources.republica_brasao_cinza_cmyk;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // datesrclbl
            // 
            this.datesrclbl.AutoSize = true;
            this.datesrclbl.Location = new System.Drawing.Point(21, 269);
            this.datesrclbl.Name = "datesrclbl";
            this.datesrclbl.Size = new System.Drawing.Size(141, 13);
            this.datesrclbl.TabIndex = 29;
            this.datesrclbl.Text = "BUSCA GERAL DE DADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 376);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIVRO CAIXA";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.TabControl.ResumeLayout(false);
            this.TabInserir.ResumeLayout(false);
            this.TabInserir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.TabDelete.ResumeLayout(false);
            this.TabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TabUpdate.ResumeLayout(false);
            this.TabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TabSelect.ResumeLayout(false);
            this.TabSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabInserir;
        private System.Windows.Forms.TabPage TabDelete;
        private System.Windows.Forms.Label despesaslblinsert;
        private System.Windows.Forms.Label receitalblinsert;
        private System.Windows.Forms.Label eventlblinsert;
        private System.Windows.Forms.Label datelblinsert;
        private System.Windows.Forms.TextBox receitasinsertTxt;
        private System.Windows.Forms.TextBox despesasinsertTxt;
        private System.Windows.Forms.TextBox eventinsertTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox iddeleteTxt;
        private System.Windows.Forms.TabPage TabUpdate;
        private System.Windows.Forms.TabPage TabSelect;
        private System.Windows.Forms.DateTimePicker datecalendarinsert;
        private System.Windows.Forms.Label iddeletelbl;
        private System.Windows.Forms.DateTimePicker datecalendarupdate;
        private System.Windows.Forms.Label despesaslblupdate;
        private System.Windows.Forms.Label eventlblupdate;
        private System.Windows.Forms.Label datelblupdate;
        private System.Windows.Forms.TextBox receitasupdateTxt;
        private System.Windows.Forms.TextBox despesasupdateTxt;
        private System.Windows.Forms.TextBox eventupdateTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label idupdatelbl;
        private System.Windows.Forms.TextBox idupdateTxt;
        private System.Windows.Forms.Label receitaslblupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label datesrclbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectImpressora;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtFolhaPrinter;
        private System.Windows.Forms.Label label1;
    }
}

