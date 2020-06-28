namespace VsSourceExtractor
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeInputButton = new System.Windows.Forms.Button();
            this.InputPathTextbox = new System.Windows.Forms.TextBox();
            this.OutputPathTextbox = new System.Windows.Forms.TextBox();
            this.ChangeOutputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearPackagesCheckbox = new System.Windows.Forms.CheckBox();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.ExitCheckbox = new System.Windows.Forms.CheckBox();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source folder";
            // 
            // ChangeInputButton
            // 
            this.ChangeInputButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeInputButton.Location = new System.Drawing.Point(282, 26);
            this.ChangeInputButton.Name = "ChangeInputButton";
            this.ChangeInputButton.Size = new System.Drawing.Size(86, 23);
            this.ChangeInputButton.TabIndex = 1;
            this.ChangeInputButton.Text = "Change";
            this.ChangeInputButton.UseVisualStyleBackColor = true;
            this.ChangeInputButton.Click += new System.EventHandler(this.ChangeInputButton_Click);
            // 
            // InputPathTextbox
            // 
            this.InputPathTextbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPathTextbox.HideSelection = false;
            this.InputPathTextbox.Location = new System.Drawing.Point(15, 26);
            this.InputPathTextbox.Name = "InputPathTextbox";
            this.InputPathTextbox.ReadOnly = true;
            this.InputPathTextbox.ShortcutsEnabled = false;
            this.InputPathTextbox.Size = new System.Drawing.Size(261, 22);
            this.InputPathTextbox.TabIndex = 2;
            this.InputPathTextbox.TabStop = false;
            // 
            // OutputPathTextbox
            // 
            this.OutputPathTextbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputPathTextbox.HideSelection = false;
            this.OutputPathTextbox.Location = new System.Drawing.Point(15, 69);
            this.OutputPathTextbox.Name = "OutputPathTextbox";
            this.OutputPathTextbox.ReadOnly = true;
            this.OutputPathTextbox.ShortcutsEnabled = false;
            this.OutputPathTextbox.Size = new System.Drawing.Size(261, 22);
            this.OutputPathTextbox.TabIndex = 4;
            this.OutputPathTextbox.TabStop = false;
            // 
            // ChangeOutputButton
            // 
            this.ChangeOutputButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeOutputButton.Location = new System.Drawing.Point(282, 69);
            this.ChangeOutputButton.Name = "ChangeOutputButton";
            this.ChangeOutputButton.Size = new System.Drawing.Size(86, 23);
            this.ChangeOutputButton.TabIndex = 3;
            this.ChangeOutputButton.Text = "Change";
            this.ChangeOutputButton.UseVisualStyleBackColor = true;
            this.ChangeOutputButton.Click += new System.EventHandler(this.ChangeOutputButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output path";
            // 
            // ClearPackagesCheckbox
            // 
            this.ClearPackagesCheckbox.AutoSize = true;
            this.ClearPackagesCheckbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearPackagesCheckbox.Location = new System.Drawing.Point(15, 126);
            this.ClearPackagesCheckbox.Name = "ClearPackagesCheckbox";
            this.ClearPackagesCheckbox.Size = new System.Drawing.Size(123, 18);
            this.ClearPackagesCheckbox.TabIndex = 7;
            this.ClearPackagesCheckbox.Text = "Clear packages";
            this.ClearPackagesCheckbox.UseVisualStyleBackColor = true;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractButton.Location = new System.Drawing.Point(15, 97);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(353, 23);
            this.ExtractButton.TabIndex = 8;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // ExitCheckbox
            // 
            this.ExitCheckbox.AutoSize = true;
            this.ExitCheckbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitCheckbox.Location = new System.Drawing.Point(148, 126);
            this.ExitCheckbox.Name = "ExitCheckbox";
            this.ExitCheckbox.Size = new System.Drawing.Size(49, 18);
            this.ExitCheckbox.TabIndex = 9;
            this.ExitCheckbox.Text = "Exit";
            this.ExitCheckbox.UseVisualStyleBackColor = true;
            // 
            // Progressbar
            // 
            this.Progressbar.Location = new System.Drawing.Point(211, 126);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(153, 18);
            this.Progressbar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 155);
            this.Controls.Add(this.Progressbar);
            this.Controls.Add(this.ExitCheckbox);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.ClearPackagesCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputPathTextbox);
            this.Controls.Add(this.ChangeOutputButton);
            this.Controls.Add(this.InputPathTextbox);
            this.Controls.Add(this.ChangeInputButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualStudio Source Extractor by Thomas Anderson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeInputButton;
        private System.Windows.Forms.TextBox InputPathTextbox;
        private System.Windows.Forms.TextBox OutputPathTextbox;
        private System.Windows.Forms.Button ChangeOutputButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ClearPackagesCheckbox;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.CheckBox ExitCheckbox;
        private System.Windows.Forms.ProgressBar Progressbar;
    }
}

