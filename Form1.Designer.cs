
namespace _4enLinea
{
    partial class Menu_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_form));
            this.play_btn = new System.Windows.Forms.Button();
            this.inst_btn = new System.Windows.Forms.Button();
            this.users_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.play_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.play_btn.Location = new System.Drawing.Point(215, 286);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(117, 31);
            this.play_btn.TabIndex = 0;
            this.play_btn.Text = "Jugar";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // inst_btn
            // 
            this.inst_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.inst_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.inst_btn.FlatAppearance.BorderSize = 0;
            this.inst_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inst_btn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inst_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.inst_btn.Location = new System.Drawing.Point(474, 286);
            this.inst_btn.Name = "inst_btn";
            this.inst_btn.Size = new System.Drawing.Size(142, 31);
            this.inst_btn.TabIndex = 1;
            this.inst_btn.Text = "Instrucciones";
            this.inst_btn.UseVisualStyleBackColor = false;
            this.inst_btn.Click += new System.EventHandler(this.inst_btn_Click);
            // 
            // users_btn
            // 
            this.users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.users_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.users_btn.FlatAppearance.BorderSize = 0;
            this.users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_btn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.users_btn.Location = new System.Drawing.Point(215, 356);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(117, 31);
            this.users_btn.TabIndex = 2;
            this.users_btn.Text = "Perfiles";
            this.users_btn.UseVisualStyleBackColor = false;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.exit_btn.Location = new System.Drawing.Point(487, 356);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(117, 31);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Salir";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 473);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.users_btn);
            this.Controls.Add(this.inst_btn);
            this.Controls.Add(this.play_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4enLinea";
            this.Load += new System.EventHandler(this.Menu_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button inst_btn;
        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

