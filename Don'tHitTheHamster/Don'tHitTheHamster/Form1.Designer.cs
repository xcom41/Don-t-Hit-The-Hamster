namespace Don_tHitTheHamster
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Enemy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.Hamster = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.hud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hud)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Enemy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Enemy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Enemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enemy.ForeColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = ((System.Drawing.Image)(resources.GetObject("Enemy.Image")));
            this.Enemy.Location = new System.Drawing.Point(118, 409);
            this.Enemy.Name = "Enemy";
            this.Enemy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Enemy.Size = new System.Drawing.Size(100, 130);
            this.Enemy.TabIndex = 0;
            this.Enemy.UseVisualStyleBackColor = false;
            this.Enemy.Click += new System.EventHandler(this.Enemy_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.Control;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Счёт: 0";
            // 
            // Hamster
            // 
            this.Hamster.BackColor = System.Drawing.Color.Transparent;
            this.Hamster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hamster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Hamster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Hamster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hamster.ForeColor = System.Drawing.Color.Transparent;
            this.Hamster.Image = ((System.Drawing.Image)(resources.GetObject("Hamster.Image")));
            this.Hamster.Location = new System.Drawing.Point(600, 100);
            this.Hamster.Name = "Hamster";
            this.Hamster.Size = new System.Drawing.Size(100, 110);
            this.Hamster.TabIndex = 2;
            this.Hamster.UseVisualStyleBackColor = false;
            this.Hamster.Click += new System.EventHandler(this.Hamster_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(356, 222);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 31);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Перезапустить";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(735, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // hud
            // 
            this.hud.Location = new System.Drawing.Point(0, 0);
            this.hud.Name = "hud";
            this.hud.Size = new System.Drawing.Size(832, 45);
            this.hud.TabIndex = 5;
            this.hud.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.hud);
            this.Controls.Add(this.Hamster);
            this.Controls.Add(this.Enemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enemy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button Hamster;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox hud;
    }
}

