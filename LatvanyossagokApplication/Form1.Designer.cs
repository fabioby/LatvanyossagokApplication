namespace LatvanyossagokApplication
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
            this.city_name = new System.Windows.Forms.TextBox();
            this.button_city = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edit_shew = new System.Windows.Forms.Button();
            this.delete_shew = new System.Windows.Forms.Button();
            this.listBox_shew = new System.Windows.Forms.ListBox();
            this.edit_city = new System.Windows.Forms.Button();
            this.delete_city = new System.Windows.Forms.Button();
            this.listBox_city = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shew_id = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_shew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.shew_description = new System.Windows.Forms.TextBox();
            this.shew_price = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shew_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.city_population = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shew_price)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.city_population)).BeginInit();
            this.SuspendLayout();
            // 
            // city_name
            // 
            this.city_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city_name.Location = new System.Drawing.Point(6, 51);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(238, 22);
            this.city_name.TabIndex = 0;
            // 
            // button_city
            // 
            this.button_city.Location = new System.Drawing.Point(6, 124);
            this.button_city.Name = "button_city";
            this.button_city.Size = new System.Drawing.Size(100, 23);
            this.button_city.TabIndex = 1;
            this.button_city.Text = "Hozzáad";
            this.button_city.UseVisualStyleBackColor = true;
            this.button_city.Click += new System.EventHandler(this.button_city_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 327);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.edit_shew);
            this.tabPage1.Controls.Add(this.delete_shew);
            this.tabPage1.Controls.Add(this.listBox_shew);
            this.tabPage1.Controls.Add(this.edit_city);
            this.tabPage1.Controls.Add(this.delete_city);
            this.tabPage1.Controls.Add(this.listBox_city);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edit_shew
            // 
            this.edit_shew.Location = new System.Drawing.Point(500, 7);
            this.edit_shew.Name = "edit_shew";
            this.edit_shew.Size = new System.Drawing.Size(155, 23);
            this.edit_shew.TabIndex = 5;
            this.edit_shew.Text = "Kijelölés módosítása";
            this.edit_shew.UseVisualStyleBackColor = true;
            // 
            // delete_shew
            // 
            this.delete_shew.Location = new System.Drawing.Point(363, 7);
            this.delete_shew.Name = "delete_shew";
            this.delete_shew.Size = new System.Drawing.Size(131, 23);
            this.delete_shew.TabIndex = 4;
            this.delete_shew.Text = "Kijelölés törlése";
            this.delete_shew.UseVisualStyleBackColor = true;
            this.delete_shew.Click += new System.EventHandler(this.delete_shew_Click_1);
            // 
            // listBox_shew
            // 
            this.listBox_shew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_shew.FormattingEnabled = true;
            this.listBox_shew.ItemHeight = 16;
            this.listBox_shew.Location = new System.Drawing.Point(363, 35);
            this.listBox_shew.Name = "listBox_shew";
            this.listBox_shew.Size = new System.Drawing.Size(350, 244);
            this.listBox_shew.TabIndex = 3;
            // 
            // edit_city
            // 
            this.edit_city.Location = new System.Drawing.Point(144, 7);
            this.edit_city.Name = "edit_city";
            this.edit_city.Size = new System.Drawing.Size(155, 23);
            this.edit_city.TabIndex = 2;
            this.edit_city.Text = "Kijelölés módosítása";
            this.edit_city.UseVisualStyleBackColor = true;
            // 
            // delete_city
            // 
            this.delete_city.Location = new System.Drawing.Point(7, 7);
            this.delete_city.Name = "delete_city";
            this.delete_city.Size = new System.Drawing.Size(131, 23);
            this.delete_city.TabIndex = 1;
            this.delete_city.Text = "Kijelölés törlése";
            this.delete_city.UseVisualStyleBackColor = true;
            this.delete_city.Click += new System.EventHandler(this.delete_city_Click_1);
            // 
            // listBox_city
            // 
            this.listBox_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_city.FormattingEnabled = true;
            this.listBox_city.ItemHeight = 16;
            this.listBox_city.Location = new System.Drawing.Point(7, 36);
            this.listBox_city.Name = "listBox_city";
            this.listBox_city.Size = new System.Drawing.Size(350, 244);
            this.listBox_city.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hozzáadás";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shew_id);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button_shew);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.shew_description);
            this.groupBox2.Controls.Add(this.shew_price);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.shew_name);
            this.groupBox2.Location = new System.Drawing.Point(272, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Új látványosság";
            // 
            // shew_id
            // 
            this.shew_id.FormattingEnabled = true;
            this.shew_id.Location = new System.Drawing.Point(6, 186);
            this.shew_id.Name = "shew_id";
            this.shew_id.Size = new System.Drawing.Size(238, 24);
            this.shew_id.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Város";
            // 
            // button_shew
            // 
            this.button_shew.Location = new System.Drawing.Point(6, 216);
            this.button_shew.Name = "button_shew";
            this.button_shew.Size = new System.Drawing.Size(100, 23);
            this.button_shew.TabIndex = 1;
            this.button_shew.Text = "Hozzáad";
            this.button_shew.UseVisualStyleBackColor = true;
            this.button_shew.Click += new System.EventHandler(this.button_shew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ár";
            // 
            // shew_description
            // 
            this.shew_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shew_description.Location = new System.Drawing.Point(6, 96);
            this.shew_description.Name = "shew_description";
            this.shew_description.Size = new System.Drawing.Size(238, 22);
            this.shew_description.TabIndex = 4;
            // 
            // shew_price
            // 
            this.shew_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shew_price.Location = new System.Drawing.Point(6, 141);
            this.shew_price.Name = "shew_price";
            this.shew_price.Size = new System.Drawing.Size(238, 22);
            this.shew_price.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leírás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Név";
            // 
            // shew_name
            // 
            this.shew_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shew_name.Location = new System.Drawing.Point(6, 51);
            this.shew_name.Name = "shew_name";
            this.shew_name.Size = new System.Drawing.Size(238, 22);
            this.shew_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_city);
            this.groupBox1.Controls.Add(this.city_population);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.city_name);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új Város";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Populáció";
            // 
            // city_population
            // 
            this.city_population.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city_population.Location = new System.Drawing.Point(6, 96);
            this.city_population.Name = "city_population";
            this.city_population.Size = new System.Drawing.Size(238, 22);
            this.city_population.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Városok és látványosságok";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shew_price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.city_population)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox city_name;
        private System.Windows.Forms.Button button_city;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button edit_city;
        private System.Windows.Forms.Button delete_city;
        private System.Windows.Forms.ListBox listBox_city;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox shew_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_shew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shew_description;
        private System.Windows.Forms.NumericUpDown shew_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shew_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown city_population;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox_shew;
        private System.Windows.Forms.Button edit_shew;
        private System.Windows.Forms.Button delete_shew;
    }
}

