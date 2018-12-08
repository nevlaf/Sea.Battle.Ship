namespace Sea.Battle.Ship.Views
{
    partial class FormMain
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seaOwnPanel = new System.Windows.Forms.Panel();
            this.seaEnemyPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SeaOwnGroupBox = new System.Windows.Forms.GroupBox();
            this.SeaEnemyGroupBox = new System.Windows.Forms.GroupBox();
            this.FourShip = new System.Windows.Forms.RadioButton();
            this.ThreeShip = new System.Windows.Forms.RadioButton();
            this.TwoShip = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countOwnFourShip = new System.Windows.Forms.TextBox();
            this.countOwnThreeShip = new System.Windows.Forms.TextBox();
            this.countOwnTwoShip = new System.Windows.Forms.TextBox();
            this.countOwnOneShip = new System.Windows.Forms.TextBox();
            this.countEnemyFourShip = new System.Windows.Forms.TextBox();
            this.countEnemyThreeShip = new System.Windows.Forms.TextBox();
            this.countEnemyTwoShip = new System.Windows.Forms.TextBox();
            this.countEnemyOneShip = new System.Windows.Forms.TextBox();
            this.Oneship = new System.Windows.Forms.RadioButton();
            this.SeaOwnGroupBox.SuspendLayout();
            this.SeaEnemyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // seaOwnPanel
            // 
            this.seaOwnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seaOwnPanel.Location = new System.Drawing.Point(20, 50);
            this.seaOwnPanel.Name = "seaOwnPanel";
            this.seaOwnPanel.Size = new System.Drawing.Size(220, 220);
            this.seaOwnPanel.TabIndex = 2;
            // 
            // seaEnemyPanel
            // 
            this.seaEnemyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seaEnemyPanel.Location = new System.Drawing.Point(260, 50);
            this.seaEnemyPanel.Name = "seaEnemyPanel";
            this.seaEnemyPanel.Size = new System.Drawing.Size(220, 220);
            this.seaEnemyPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SeaOwnGroupBox
            // 
            this.SeaOwnGroupBox.Controls.Add(this.Oneship);
            this.SeaOwnGroupBox.Controls.Add(this.countOwnOneShip);
            this.SeaOwnGroupBox.Controls.Add(this.countOwnTwoShip);
            this.SeaOwnGroupBox.Controls.Add(this.countOwnThreeShip);
            this.SeaOwnGroupBox.Controls.Add(this.countOwnFourShip);
            this.SeaOwnGroupBox.Controls.Add(this.TwoShip);
            this.SeaOwnGroupBox.Controls.Add(this.ThreeShip);
            this.SeaOwnGroupBox.Controls.Add(this.FourShip);
            this.SeaOwnGroupBox.Location = new System.Drawing.Point(20, 290);
            this.SeaOwnGroupBox.Name = "SeaOwnGroupBox";
            this.SeaOwnGroupBox.Size = new System.Drawing.Size(220, 120);
            this.SeaOwnGroupBox.TabIndex = 5;
            this.SeaOwnGroupBox.TabStop = false;
            this.SeaOwnGroupBox.Text = "OwnFleet";
            // 
            // SeaEnemyGroupBox
            // 
            this.SeaEnemyGroupBox.Controls.Add(this.countEnemyOneShip);
            this.SeaEnemyGroupBox.Controls.Add(this.countEnemyTwoShip);
            this.SeaEnemyGroupBox.Controls.Add(this.countEnemyThreeShip);
            this.SeaEnemyGroupBox.Controls.Add(this.countEnemyFourShip);
            this.SeaEnemyGroupBox.Controls.Add(this.label4);
            this.SeaEnemyGroupBox.Controls.Add(this.label3);
            this.SeaEnemyGroupBox.Controls.Add(this.label2);
            this.SeaEnemyGroupBox.Controls.Add(this.label1);
            this.SeaEnemyGroupBox.Location = new System.Drawing.Point(260, 290);
            this.SeaEnemyGroupBox.Name = "SeaEnemyGroupBox";
            this.SeaEnemyGroupBox.Size = new System.Drawing.Size(220, 120);
            this.SeaEnemyGroupBox.TabIndex = 6;
            this.SeaEnemyGroupBox.TabStop = false;
            this.SeaEnemyGroupBox.Text = "EnemyFleet";
            this.SeaEnemyGroupBox.Enter += new System.EventHandler(this.SeaEnemyGroupBox_Enter);
            // 
            // FourShip
            // 
            this.FourShip.AutoSize = true;
            this.FourShip.Location = new System.Drawing.Point(7, 20);
            this.FourShip.Name = "FourShip";
            this.FourShip.Size = new System.Drawing.Size(67, 17);
            this.FourShip.TabIndex = 0;
            this.FourShip.TabStop = true;
            this.FourShip.Text = "FourShip";
            this.FourShip.UseVisualStyleBackColor = true;
            this.FourShip.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ThreeShip
            // 
            this.ThreeShip.AutoSize = true;
            this.ThreeShip.Location = new System.Drawing.Point(7, 44);
            this.ThreeShip.Name = "ThreeShip";
            this.ThreeShip.Size = new System.Drawing.Size(74, 17);
            this.ThreeShip.TabIndex = 1;
            this.ThreeShip.TabStop = true;
            this.ThreeShip.Text = "ThreeShip";
            this.ThreeShip.UseVisualStyleBackColor = true;
            // 
            // TwoShip
            // 
            this.TwoShip.AutoSize = true;
            this.TwoShip.Location = new System.Drawing.Point(7, 67);
            this.TwoShip.Name = "TwoShip";
            this.TwoShip.Size = new System.Drawing.Size(67, 17);
            this.TwoShip.TabIndex = 2;
            this.TwoShip.TabStop = true;
            this.TwoShip.Text = "TwoShip";
            this.TwoShip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FourShip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ThreeShip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TwoShip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OneShip";
            // 
            // countOwnFourShip
            // 
            this.countOwnFourShip.Location = new System.Drawing.Point(115, 20);
            this.countOwnFourShip.Name = "countOwnFourShip";
            this.countOwnFourShip.ReadOnly = true;
            this.countOwnFourShip.Size = new System.Drawing.Size(100, 20);
            this.countOwnFourShip.TabIndex = 3;
            this.countOwnFourShip.TextChanged += new System.EventHandler(this.countOwnFourShip_TextChanged);
            // 
            // countOwnThreeShip
            // 
            this.countOwnThreeShip.Location = new System.Drawing.Point(115, 44);
            this.countOwnThreeShip.Name = "countOwnThreeShip";
            this.countOwnThreeShip.ReadOnly = true;
            this.countOwnThreeShip.Size = new System.Drawing.Size(100, 20);
            this.countOwnThreeShip.TabIndex = 4;
            // 
            // countOwnTwoShip
            // 
            this.countOwnTwoShip.Location = new System.Drawing.Point(115, 67);
            this.countOwnTwoShip.Name = "countOwnTwoShip";
            this.countOwnTwoShip.ReadOnly = true;
            this.countOwnTwoShip.Size = new System.Drawing.Size(100, 20);
            this.countOwnTwoShip.TabIndex = 5;
            // 
            // countOwnOneShip
            // 
            this.countOwnOneShip.Location = new System.Drawing.Point(115, 91);
            this.countOwnOneShip.Name = "countOwnOneShip";
            this.countOwnOneShip.ReadOnly = true;
            this.countOwnOneShip.Size = new System.Drawing.Size(100, 20);
            this.countOwnOneShip.TabIndex = 6;
            // 
            // countEnemyFourShip
            // 
            this.countEnemyFourShip.Location = new System.Drawing.Point(93, 19);
            this.countEnemyFourShip.Name = "countEnemyFourShip";
            this.countEnemyFourShip.ReadOnly = true;
            this.countEnemyFourShip.Size = new System.Drawing.Size(100, 20);
            this.countEnemyFourShip.TabIndex = 4;
            // 
            // countEnemyThreeShip
            // 
            this.countEnemyThreeShip.Location = new System.Drawing.Point(93, 43);
            this.countEnemyThreeShip.Name = "countEnemyThreeShip";
            this.countEnemyThreeShip.ReadOnly = true;
            this.countEnemyThreeShip.Size = new System.Drawing.Size(100, 20);
            this.countEnemyThreeShip.TabIndex = 5;
            // 
            // countEnemyTwoShip
            // 
            this.countEnemyTwoShip.Location = new System.Drawing.Point(93, 66);
            this.countEnemyTwoShip.Name = "countEnemyTwoShip";
            this.countEnemyTwoShip.ReadOnly = true;
            this.countEnemyTwoShip.Size = new System.Drawing.Size(100, 20);
            this.countEnemyTwoShip.TabIndex = 6;
            // 
            // countEnemyOneShip
            // 
            this.countEnemyOneShip.Location = new System.Drawing.Point(93, 88);
            this.countEnemyOneShip.Name = "countEnemyOneShip";
            this.countEnemyOneShip.ReadOnly = true;
            this.countEnemyOneShip.Size = new System.Drawing.Size(100, 20);
            this.countEnemyOneShip.TabIndex = 7;
            // 
            // Oneship
            // 
            this.Oneship.AutoSize = true;
            this.Oneship.Location = new System.Drawing.Point(7, 89);
            this.Oneship.Name = "Oneship";
            this.Oneship.Size = new System.Drawing.Size(64, 17);
            this.Oneship.TabIndex = 8;
            this.Oneship.TabStop = true;
            this.Oneship.Text = "Oneship";
            this.Oneship.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 454);
            this.Controls.Add(this.SeaEnemyGroupBox);
            this.Controls.Add(this.SeaOwnGroupBox);
            this.Controls.Add(this.seaEnemyPanel);
            this.Controls.Add(this.seaOwnPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeaBattleShips";
            this.SeaOwnGroupBox.ResumeLayout(false);
            this.SeaOwnGroupBox.PerformLayout();
            this.SeaEnemyGroupBox.ResumeLayout(false);
            this.SeaEnemyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel seaOwnPanel;
        private System.Windows.Forms.Panel seaEnemyPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox SeaOwnGroupBox;
        private System.Windows.Forms.GroupBox SeaEnemyGroupBox;
        private System.Windows.Forms.TextBox countOwnOneShip;
        private System.Windows.Forms.TextBox countOwnTwoShip;
        private System.Windows.Forms.TextBox countOwnThreeShip;
        private System.Windows.Forms.TextBox countOwnFourShip;
        private System.Windows.Forms.RadioButton TwoShip;
        private System.Windows.Forms.RadioButton ThreeShip;
        private System.Windows.Forms.RadioButton FourShip;
        private System.Windows.Forms.TextBox countEnemyOneShip;
        private System.Windows.Forms.TextBox countEnemyTwoShip;
        private System.Windows.Forms.TextBox countEnemyThreeShip;
        private System.Windows.Forms.TextBox countEnemyFourShip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Oneship;
    }
}

