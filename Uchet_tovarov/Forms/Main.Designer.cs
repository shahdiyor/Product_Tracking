namespace Uchet_tovarov
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tov = new System.Windows.Forms.Button();
            this.zaka = new System.Windows.Forms.Button();
            this.postavs = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.catego = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.posrad = new System.Windows.Forms.RadioButton();
            this.cateRad = new System.Windows.Forms.RadioButton();
            this.nazRad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(851, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiToolStripMenuItem,
            this.списокТоваровToolStripMenuItem,
            this.поставщикиToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // invoiToolStripMenuItem
            // 
            this.invoiToolStripMenuItem.Name = "invoiToolStripMenuItem";
            this.invoiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invoiToolStripMenuItem.Text = "Накладная";
            this.invoiToolStripMenuItem.Click += new System.EventHandler(this.invoiToolStripMenuItem_Click);
            // 
            // списокТоваровToolStripMenuItem
            // 
            this.списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            this.списокТоваровToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокТоваровToolStripMenuItem.Text = "Список товаров";
            this.списокТоваровToolStripMenuItem.Click += new System.EventHandler(this.списокТоваровToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(700, 412);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(118, 32);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(824, 412);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(118, 32);
            this.del.TabIndex = 3;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(861, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.search_Click);
            // 
            // tov
            // 
            this.tov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tov.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tov.Location = new System.Drawing.Point(12, 68);
            this.tov.Name = "tov";
            this.tov.Size = new System.Drawing.Size(86, 35);
            this.tov.TabIndex = 7;
            this.tov.Text = "Товары";
            this.tov.UseVisualStyleBackColor = false;
            this.tov.Click += new System.EventHandler(this.Tovar_Click);
            // 
            // zaka
            // 
            this.zaka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zaka.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zaka.Location = new System.Drawing.Point(12, 109);
            this.zaka.Name = "zaka";
            this.zaka.Size = new System.Drawing.Size(86, 35);
            this.zaka.TabIndex = 9;
            this.zaka.Text = "Заказы";
            this.zaka.UseVisualStyleBackColor = false;
            this.zaka.Click += new System.EventHandler(this.zakaz_Click);
            // 
            // postavs
            // 
            this.postavs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.postavs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.postavs.Location = new System.Drawing.Point(12, 150);
            this.postavs.Name = "postavs";
            this.postavs.Size = new System.Drawing.Size(86, 35);
            this.postavs.TabIndex = 9;
            this.postavs.TabStop = false;
            this.postavs.Text = "Поставщики";
            this.postavs.UseVisualStyleBackColor = false;
            this.postavs.Click += new System.EventHandler(this.postav_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(576, 412);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 32);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // catego
            // 
            this.catego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.catego.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.catego.Location = new System.Drawing.Point(12, 191);
            this.catego.Name = "catego";
            this.catego.Size = new System.Drawing.Size(86, 35);
            this.catego.TabIndex = 12;
            this.catego.Text = "Категории";
            this.catego.UseVisualStyleBackColor = false;
            this.catego.Click += new System.EventHandler(this.categ_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(463, 412);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(107, 32);
            this.about.TabIndex = 13;
            this.about.Text = "About the order";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(920, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // posrad
            // 
            this.posrad.AutoSize = true;
            this.posrad.Location = new System.Drawing.Point(766, 30);
            this.posrad.Name = "posrad";
            this.posrad.Size = new System.Drawing.Size(88, 17);
            this.posrad.TabIndex = 16;
            this.posrad.TabStop = true;
            this.posrad.Text = "Поставщику";
            this.posrad.UseVisualStyleBackColor = true;
            this.posrad.CheckedChanged += new System.EventHandler(this.posrad_CheckedChanged);
            // 
            // cateRad
            // 
            this.cateRad.AutoSize = true;
            this.cateRad.Location = new System.Drawing.Point(675, 30);
            this.cateRad.Name = "cateRad";
            this.cateRad.Size = new System.Drawing.Size(78, 17);
            this.cateRad.TabIndex = 17;
            this.cateRad.TabStop = true;
            this.cateRad.Text = "Категории";
            this.cateRad.UseVisualStyleBackColor = true;
            this.cateRad.CheckedChanged += new System.EventHandler(this.cateRad_CheckedChanged);
            // 
            // nazRad
            // 
            this.nazRad.AutoSize = true;
            this.nazRad.Location = new System.Drawing.Point(584, 30);
            this.nazRad.Name = "nazRad";
            this.nazRad.Size = new System.Drawing.Size(77, 17);
            this.nazRad.TabIndex = 18;
            this.nazRad.TabStop = true;
            this.nazRad.Text = "Названию";
            this.nazRad.UseVisualStyleBackColor = true;
            this.nazRad.CheckedChanged += new System.EventHandler(this.nazRad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Поиск по:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(727, 5);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 38);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazRad);
            this.Controls.Add(this.cateRad);
            this.Controls.Add(this.posrad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.del);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tov);
            this.Controls.Add(this.zaka);
            this.Controls.Add(this.postavs);
            this.Controls.Add(this.catego);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button tov;
        private System.Windows.Forms.Button zaka;
        private System.Windows.Forms.Button postavs;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button catego;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton posrad;
        private System.Windows.Forms.RadioButton cateRad;
        private System.Windows.Forms.RadioButton nazRad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ToolStripMenuItem invoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

