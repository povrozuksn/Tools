namespace Tools
{
    partial class DesingUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelFontBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ExamplePanel = new System.Windows.Forms.Panel();
            this.PanelColorBTN = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ExampleTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxColorBTN = new System.Windows.Forms.Button();
            this.TextBoxFontBTN = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonColorBTN = new System.Windows.Forms.Button();
            this.ButtonFontBTN = new System.Windows.Forms.Button();
            this.ExampleButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Область дизайна";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.LabelFontBTN);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(815, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Надпись";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(588, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Образец";
            // 
            // LabelFontBTN
            // 
            this.LabelFontBTN.Location = new System.Drawing.Point(37, 103);
            this.LabelFontBTN.Name = "LabelFontBTN";
            this.LabelFontBTN.Size = new System.Drawing.Size(500, 50);
            this.LabelFontBTN.TabIndex = 1;
            this.LabelFontBTN.Text = "Выберите шрифт, размер и цвет текста надписи";
            this.LabelFontBTN.UseVisualStyleBackColor = true;
            this.LabelFontBTN.Click += new System.EventHandler(this.LabelFontBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пример Надписи";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ExamplePanel);
            this.tabPage2.Controls.Add(this.PanelColorBTN);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Панель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(499, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Образец";
            // 
            // ExamplePanel
            // 
            this.ExamplePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExamplePanel.Location = new System.Drawing.Point(504, 63);
            this.ExamplePanel.Name = "ExamplePanel";
            this.ExamplePanel.Size = new System.Drawing.Size(248, 251);
            this.ExamplePanel.TabIndex = 1;
            // 
            // PanelColorBTN
            // 
            this.PanelColorBTN.Location = new System.Drawing.Point(64, 123);
            this.PanelColorBTN.Name = "PanelColorBTN";
            this.PanelColorBTN.Size = new System.Drawing.Size(384, 51);
            this.PanelColorBTN.TabIndex = 0;
            this.PanelColorBTN.Text = "Выберите цвет фона панели";
            this.PanelColorBTN.UseVisualStyleBackColor = true;
            this.PanelColorBTN.Click += new System.EventHandler(this.PanelColorBTN_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.ExampleTextBox);
            this.tabPage3.Controls.Add(this.TextBoxColorBTN);
            this.tabPage3.Controls.Add(this.TextBoxFontBTN);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(815, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поле ввода";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(572, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Образец";
            // 
            // ExampleTextBox
            // 
            this.ExampleTextBox.Location = new System.Drawing.Point(572, 126);
            this.ExampleTextBox.Name = "ExampleTextBox";
            this.ExampleTextBox.Size = new System.Drawing.Size(298, 30);
            this.ExampleTextBox.TabIndex = 2;
            // 
            // TextBoxColorBTN
            // 
            this.TextBoxColorBTN.Location = new System.Drawing.Point(17, 154);
            this.TextBoxColorBTN.Name = "TextBoxColorBTN";
            this.TextBoxColorBTN.Size = new System.Drawing.Size(549, 51);
            this.TextBoxColorBTN.TabIndex = 1;
            this.TextBoxColorBTN.Text = "Выберите цвет фона поля ввода";
            this.TextBoxColorBTN.UseVisualStyleBackColor = true;
            this.TextBoxColorBTN.Click += new System.EventHandler(this.TextBoxColorBTN_Click);
            // 
            // TextBoxFontBTN
            // 
            this.TextBoxFontBTN.Location = new System.Drawing.Point(17, 90);
            this.TextBoxFontBTN.Name = "TextBoxFontBTN";
            this.TextBoxFontBTN.Size = new System.Drawing.Size(549, 46);
            this.TextBoxFontBTN.TabIndex = 0;
            this.TextBoxFontBTN.Text = "Выберите шрифт, размер и цвет текста поля ввода";
            this.TextBoxFontBTN.UseVisualStyleBackColor = true;
            this.TextBoxFontBTN.Click += new System.EventHandler(this.TextBoxFontBTN_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ExampleButton);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.ButtonColorBTN);
            this.tabPage4.Controls.Add(this.ButtonFontBTN);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(815, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Кнопка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(570, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Образец";
            // 
            // ButtonColorBTN
            // 
            this.ButtonColorBTN.Location = new System.Drawing.Point(15, 149);
            this.ButtonColorBTN.Name = "ButtonColorBTN";
            this.ButtonColorBTN.Size = new System.Drawing.Size(549, 51);
            this.ButtonColorBTN.TabIndex = 5;
            this.ButtonColorBTN.Text = "Выберите цвет фона  кнопки";
            this.ButtonColorBTN.UseVisualStyleBackColor = true;
            this.ButtonColorBTN.Click += new System.EventHandler(this.ButtonColorBTN_Click);
            // 
            // ButtonFontBTN
            // 
            this.ButtonFontBTN.Location = new System.Drawing.Point(15, 85);
            this.ButtonFontBTN.Name = "ButtonFontBTN";
            this.ButtonFontBTN.Size = new System.Drawing.Size(549, 46);
            this.ButtonFontBTN.TabIndex = 4;
            this.ButtonFontBTN.Text = "Выберите шрифт, размер и цвет текста кнопки";
            this.ButtonFontBTN.UseVisualStyleBackColor = true;
            this.ButtonFontBTN.Click += new System.EventHandler(this.ButtonFontBTN_Click);
            // 
            // ExampleButton
            // 
            this.ExampleButton.Location = new System.Drawing.Point(584, 125);
            this.ExampleButton.Name = "ExampleButton";
            this.ExampleButton.Size = new System.Drawing.Size(203, 47);
            this.ExampleButton.TabIndex = 7;
            this.ExampleButton.Text = "Текст";
            this.ExampleButton.UseVisualStyleBackColor = true;
            // 
            // DesingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DesingUC";
            this.Size = new System.Drawing.Size(823, 464);
            this.Load += new System.EventHandler(this.DesingUC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button LabelFontBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel ExamplePanel;
        private System.Windows.Forms.Button PanelColorBTN;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button TextBoxFontBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExampleTextBox;
        private System.Windows.Forms.Button TextBoxColorBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonColorBTN;
        private System.Windows.Forms.Button ButtonFontBTN;
        private System.Windows.Forms.Button ExampleButton;
    }
}
