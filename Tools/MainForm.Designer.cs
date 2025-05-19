namespace Tools
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Магазины");
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.DesingButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.PasTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ValComboBox = new System.Windows.Forms.ComboBox();
            this.ValsLabel = new System.Windows.Forms.Label();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DisignBottonCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.DownPanel.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.SystemColors.Info;
            this.AuthPanel.Controls.Add(this.DesingButton);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AdminButton);
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.PasTextBox);
            this.AuthPanel.Controls.Add(this.label2);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.label1);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1307, 62);
            this.AuthPanel.TabIndex = 0;
            // 
            // DesingButton
            // 
            this.DesingButton.Location = new System.Drawing.Point(758, 10);
            this.DesingButton.Name = "DesingButton";
            this.DesingButton.Size = new System.Drawing.Size(131, 28);
            this.DesingButton.TabIndex = 7;
            this.DesingButton.Text = "Дизайн";
            this.DesingButton.UseVisualStyleBackColor = true;
            this.DesingButton.Click += new System.EventHandler(this.DesingButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(16, 17);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(64, 25);
            this.HelloLabel.TabIndex = 6;
            this.HelloLabel.Text = "label3";
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(900, 9);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(225, 30);
            this.AdminButton.TabIndex = 5;
            this.AdminButton.Text = "Панель администратора";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(1140, 9);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(155, 30);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            // 
            // PasTextBox
            // 
            this.PasTextBox.Location = new System.Drawing.Point(405, 12);
            this.PasTextBox.Name = "PasTextBox";
            this.PasTextBox.PasswordChar = '*';
            this.PasTextBox.Size = new System.Drawing.Size(163, 30);
            this.PasTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(109, 12);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(163, 30);
            this.LoginTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(591, 9);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(155, 30);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 62);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1307, 540);
            this.MainPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.76687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.23313F));
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1307, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(343, 6);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(958, 528);
            this.InfoPanel.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip3;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Магазины";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(328, 528);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWidthToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(267, 28);
            // 
            // changeWidthToolStripMenuItem
            // 
            this.changeWidthToolStripMenuItem.Name = "changeWidthToolStripMenuItem";
            this.changeWidthToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.changeWidthToolStripMenuItem.Text = "Изменение ширины блока";
            this.changeWidthToolStripMenuItem.Click += new System.EventHandler(this.changeWidthToolStripMenuItem_Click);
            // 
            // DownPanel
            // 
            this.DownPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DownPanel.ContextMenuStrip = this.contextMenuStrip2;
            this.DownPanel.Controls.Add(this.ValComboBox);
            this.DownPanel.Controls.Add(this.ValsLabel);
            this.DownPanel.Controls.Add(this.WeatherLabel);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 553);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(1307, 49);
            this.DownPanel.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeBlockToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(260, 28);
            // 
            // ChangeBlockToolStripMenuItem
            // 
            this.ChangeBlockToolStripMenuItem.Name = "ChangeBlockToolStripMenuItem";
            this.ChangeBlockToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.ChangeBlockToolStripMenuItem.Text = "Изменение высоты блока";
            this.ChangeBlockToolStripMenuItem.Click += new System.EventHandler(this.ChangeBlockToolStripMenuItem_Click);
            // 
            // ValComboBox
            // 
            this.ValComboBox.FormattingEnabled = true;
            this.ValComboBox.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR",
            "CNY"});
            this.ValComboBox.Location = new System.Drawing.Point(376, 14);
            this.ValComboBox.Name = "ValComboBox";
            this.ValComboBox.Size = new System.Drawing.Size(121, 33);
            this.ValComboBox.TabIndex = 2;
            this.ValComboBox.SelectedIndexChanged += new System.EventHandler(this.ValComboBox_SelectedIndexChanged);
            // 
            // ValsLabel
            // 
            this.ValsLabel.AutoSize = true;
            this.ValsLabel.Location = new System.Drawing.Point(548, 14);
            this.ValsLabel.Name = "ValsLabel";
            this.ValsLabel.Size = new System.Drawing.Size(64, 25);
            this.ValsLabel.TabIndex = 1;
            this.ValsLabel.Text = "label3";
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Location = new System.Drawing.Point(15, 14);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(64, 25);
            this.WeatherLabel.TabIndex = 0;
            this.WeatherLabel.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisignBottonCMS});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // DisignBottonCMS
            // 
            this.DisignBottonCMS.Name = "DisignBottonCMS";
            this.DisignBottonCMS.Size = new System.Drawing.Size(199, 24);
            this.DisignBottonCMS.Text = "Дизайн элемента";
            this.DisignBottonCMS.Click += new System.EventHandler(this.DisignBottonCMS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 602);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Инструменты для дома и стройки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.DownPanel.ResumeLayout(false);
            this.DownPanel.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel DownPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox PasTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Button RegButton;
        public System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DesingButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DisignBottonCMS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ChangeBlockToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem changeWidthToolStripMenuItem;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Label ValsLabel;
        private System.Windows.Forms.ComboBox ValComboBox;
    }
}

