namespace SaveDatHelper
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_secure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
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
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.e_mousedown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_mousemove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.e_mouseup);
            // 
            // btn_secure
            // 
            this.btn_secure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_secure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_secure.BackgroundImage")));
            this.btn_secure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_secure.FlatAppearance.BorderSize = 0;
            this.btn_secure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secure.Location = new System.Drawing.Point(12, 38);
            this.btn_secure.Name = "btn_secure";
            this.btn_secure.Size = new System.Drawing.Size(300, 300);
            this.btn_secure.TabIndex = 1;
            this.btn_secure.UseVisualStyleBackColor = false;
            this.btn_secure.Click += new System.EventHandler(this.btn_secure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All icons are made by AlpKahro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(408, 344);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(120, 120);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(624, 38);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(300, 300);
            this.btn_save.TabIndex = 0;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_replace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_replace.BackgroundImage")));
            this.btn_replace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_replace.FlatAppearance.BorderSize = 0;
            this.btn_replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_replace.Location = new System.Drawing.Point(318, 38);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(300, 300);
            this.btn_replace.TabIndex = 2;
            this.btn_replace.UseVisualStyleBackColor = false;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(936, 500);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_secure);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.Text = "Save Dat Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_secure;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_replace;
    }
}

