
namespace PlantsVsZombieTrainer
{
    partial class mainForm
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSun = new System.Windows.Forms.Label();
            this.txtSun = new System.Windows.Forms.TextBox();
            this.btnApplySun = new System.Windows.Forms.Button();
            this.cbInstantCharger = new System.Windows.Forms.CheckBox();
            this.cbGodMode = new System.Windows.Forms.CheckBox();
            this.cbRapidFire = new System.Windows.Forms.CheckBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(447, 40);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PlantsVsZombieTrainer.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(405, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Plants Vs Zombie Trainer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlantsVsZombieTrainer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(152, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Location = new System.Drawing.Point(45, 198);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(96, 17);
            this.lblSun.TabIndex = 2;
            this.lblSun.Text = "Giá trị mặt trời:";
            // 
            // txtSun
            // 
            this.txtSun.Location = new System.Drawing.Point(156, 195);
            this.txtSun.Name = "txtSun";
            this.txtSun.Size = new System.Drawing.Size(139, 25);
            this.txtSun.TabIndex = 3;
            this.txtSun.Text = "9999";
            // 
            // btnApplySun
            // 
            this.btnApplySun.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApplySun.FlatAppearance.BorderSize = 0;
            this.btnApplySun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySun.ForeColor = System.Drawing.Color.White;
            this.btnApplySun.Location = new System.Drawing.Point(322, 195);
            this.btnApplySun.Name = "btnApplySun";
            this.btnApplySun.Size = new System.Drawing.Size(75, 25);
            this.btnApplySun.TabIndex = 4;
            this.btnApplySun.Text = "Áp Dụng";
            this.btnApplySun.UseVisualStyleBackColor = false;
            this.btnApplySun.Click += new System.EventHandler(this.btnApplySun_Click);
            // 
            // cbInstantCharger
            // 
            this.cbInstantCharger.AutoSize = true;
            this.cbInstantCharger.Location = new System.Drawing.Point(48, 258);
            this.cbInstantCharger.Name = "cbInstantCharger";
            this.cbInstantCharger.Size = new System.Drawing.Size(123, 21);
            this.cbInstantCharger.TabIndex = 5;
            this.cbInstantCharger.Text = "Hồi ngay lập tức";
            this.cbInstantCharger.UseVisualStyleBackColor = true;
            this.cbInstantCharger.CheckedChanged += new System.EventHandler(this.cbInstantCharger_CheckedChanged);
            // 
            // cbGodMode
            // 
            this.cbGodMode.AutoSize = true;
            this.cbGodMode.Location = new System.Drawing.Point(48, 299);
            this.cbGodMode.Name = "cbGodMode";
            this.cbGodMode.Size = new System.Drawing.Size(91, 21);
            this.cbGodMode.TabIndex = 6;
            this.cbGodMode.Text = "God Mode";
            this.cbGodMode.UseVisualStyleBackColor = true;
            this.cbGodMode.CheckedChanged += new System.EventHandler(this.cbGodMode_CheckedChanged);
            // 
            // cbRapidFire
            // 
            this.cbRapidFire.AutoSize = true;
            this.cbRapidFire.Location = new System.Drawing.Point(48, 340);
            this.cbRapidFire.Name = "cbRapidFire";
            this.cbRapidFire.Size = new System.Drawing.Size(86, 21);
            this.cbRapidFire.TabIndex = 7;
            this.cbRapidFire.Text = "Rapid Fire";
            this.cbRapidFire.UseVisualStyleBackColor = true;
            this.cbRapidFire.CheckedChanged += new System.EventHandler(this.cbRapidFire_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(447, 386);
            this.Controls.Add(this.cbRapidFire);
            this.Controls.Add(this.cbGodMode);
            this.Controls.Add(this.cbInstantCharger);
            this.Controls.Add(this.btnApplySun);
            this.Controls.Add(this.txtSun);
            this.Controls.Add(this.lblSun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.TextBox txtSun;
        private System.Windows.Forms.Button btnApplySun;
        private System.Windows.Forms.CheckBox cbInstantCharger;
        private System.Windows.Forms.CheckBox cbGodMode;
        private System.Windows.Forms.CheckBox cbRapidFire;
    }
}

