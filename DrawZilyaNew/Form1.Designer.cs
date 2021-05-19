
namespace DrawZilyaNew
{
    partial class Glav_Draw
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
            this.pnlBut = new System.Windows.Forms.Panel();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.pnlBut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBut.Controls.Add(this.btnC);
            this.pnlBut.Controls.Add(this.btnT);
            this.pnlBut.Controls.Add(this.btnR);
            this.pnlBut.Controls.Add(this.btnL);
            this.pnlBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBut.Location = new System.Drawing.Point(0, 0);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(800, 100);
            this.pnlBut.TabIndex = 0;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 100);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(800, 350);
            this.pnlDraw.TabIndex = 1;
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(31, 5);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(102, 89);
            this.btnL.TabIndex = 0;
            this.btnL.Text = "LINE";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(436, 5);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(102, 89);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "RECTANGLE";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(652, 5);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(102, 89);
            this.btnT.TabIndex = 2;
            this.btnT.Text = "TRIANGLE";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(221, 5);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(102, 89);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "CIRCLE";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Glav_Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.pnlBut);
            this.Name = "Glav_Draw";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
    }
}

