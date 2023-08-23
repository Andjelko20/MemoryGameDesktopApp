
namespace MemoryGame
{
    partial class Top10
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top10));
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.size24radioButton = new System.Windows.Forms.RadioButton();
			this.size18radioButton = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(134, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "TOP 10 IGRAČA";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Coral;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBox1.Location = new System.Drawing.Point(32, 134);
			this.textBox1.MaxLength = 80000;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(378, 161);
			this.textBox1.TabIndex = 0;
			this.textBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Coral;
			this.groupBox1.Controls.Add(this.size24radioButton);
			this.groupBox1.Controls.Add(this.size18radioButton);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(138, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(165, 69);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dimenzije : ";
			// 
			// size24radioButton
			// 
			this.size24radioButton.AutoSize = true;
			this.size24radioButton.ForeColor = System.Drawing.Color.Black;
			this.size24radioButton.Location = new System.Drawing.Point(22, 44);
			this.size24radioButton.Name = "size24radioButton";
			this.size24radioButton.Size = new System.Drawing.Size(83, 17);
			this.size24radioButton.TabIndex = 1;
			this.size24radioButton.TabStop = true;
			this.size24radioButton.Text = "Tabla 3x4x2";
			this.size24radioButton.UseVisualStyleBackColor = true;
			this.size24radioButton.CheckedChanged += new System.EventHandler(this.size24radioButton_CheckedChanged);
			// 
			// size18radioButton
			// 
			this.size18radioButton.AutoSize = true;
			this.size18radioButton.ForeColor = System.Drawing.Color.Black;
			this.size18radioButton.Location = new System.Drawing.Point(22, 20);
			this.size18radioButton.Name = "size18radioButton";
			this.size18radioButton.Size = new System.Drawing.Size(83, 17);
			this.size18radioButton.TabIndex = 0;
			this.size18radioButton.TabStop = true;
			this.size18radioButton.Text = "Tabla 3x3x2";
			this.size18radioButton.UseVisualStyleBackColor = true;
			this.size18radioButton.CheckedChanged += new System.EventHandler(this.size18radioButton_CheckedChanged);
			// 
			// Top10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::MemoryGame.Properties.Resources.Background_Image;
			this.ClientSize = new System.Drawing.Size(449, 321);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(465, 360);
			this.MinimumSize = new System.Drawing.Size(465, 360);
			this.Name = "Top10";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Top 10 igrača";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton size24radioButton;
        private System.Windows.Forms.RadioButton size18radioButton;
    }
}