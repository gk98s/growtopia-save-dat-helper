namespace SaveDatHelper
{
    partial class settingsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsform));
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.btn_browse1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_browse2 = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Location = new System.Drawing.Point(899, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 32);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.e_mousedown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_mousemove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.e_mouseup);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(382, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_2
            // 
            this.tb_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.tb_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.ForeColor = System.Drawing.Color.White;
            this.tb_2.Location = new System.Drawing.Point(232, 80);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(176, 23);
            this.tb_2.TabIndex = 3;
            // 
            // btn_browse1
            // 
            this.btn_browse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_browse1.FlatAppearance.BorderSize = 0;
            this.btn_browse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse1.ForeColor = System.Drawing.Color.White;
            this.btn_browse1.Location = new System.Drawing.Point(12, 109);
            this.btn_browse1.Name = "btn_browse1";
            this.btn_browse1.Size = new System.Drawing.Size(176, 33);
            this.btn_browse1.TabIndex = 4;
            this.btn_browse1.Text = "Browse";
            this.btn_browse1.UseVisualStyleBackColor = false;
            this.btn_browse1.Click += new System.EventHandler(this.btn_browse1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "GT Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_browse2
            // 
            this.btn_browse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_browse2.FlatAppearance.BorderSize = 0;
            this.btn_browse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse2.ForeColor = System.Drawing.Color.White;
            this.btn_browse2.Location = new System.Drawing.Point(232, 109);
            this.btn_browse2.Name = "btn_browse2";
            this.btn_browse2.Size = new System.Drawing.Size(176, 33);
            this.btn_browse2.TabIndex = 7;
            this.btn_browse2.Text = "Browse";
            this.btn_browse2.UseVisualStyleBackColor = false;
            this.btn_browse2.Click += new System.EventHandler(this.btn_browse2_Click);
            // 
            // tb_1
            // 
            this.tb_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.tb_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_1.ForeColor = System.Drawing.Color.White;
            this.tb_1.Location = new System.Drawing.Point(12, 80);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(176, 23);
            this.tb_1.TabIndex = 6;
            this.tb_1.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(122, 151);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(176, 33);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(420, 196);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_browse2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_browse1);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsform";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button btn_browse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_browse2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Button btn_save;
    }
}