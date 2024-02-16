namespace WF_Reflector_dotNET
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDecompiler_EXE = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDecompilerDLL = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDecompilerAssemblies = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ссылкаНаGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инфоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.ToolStripMenuItemDecompilerAssemblies});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDecompiler_EXE,
            this.ToolStripMenuItemDecompilerDLL});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            // 
            // ToolStripMenuItemDecompiler_EXE
            // 
            this.ToolStripMenuItemDecompiler_EXE.Name = "ToolStripMenuItemDecompiler_EXE";
            this.ToolStripMenuItemDecompiler_EXE.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemDecompiler_EXE.Text = "Формат .exe";
            this.ToolStripMenuItemDecompiler_EXE.Click += new System.EventHandler(this.ToolStripMenuItem_Click_DecompilerAssemblies);
            // 
            // ToolStripMenuItemDecompilerDLL
            // 
            this.ToolStripMenuItemDecompilerDLL.Name = "ToolStripMenuItemDecompilerDLL";
            this.ToolStripMenuItemDecompilerDLL.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemDecompilerDLL.Text = "Формат .dll";
            this.ToolStripMenuItemDecompilerDLL.Click += new System.EventHandler(this.ToolStripMenuItem_Click_DecompilerAssemblies);
            // 
            // ToolStripMenuItemDecompilerAssemblies
            // 
            this.ToolStripMenuItemDecompilerAssemblies.Name = "ToolStripMenuItemDecompilerAssemblies";
            this.ToolStripMenuItemDecompilerAssemblies.Size = new System.Drawing.Size(217, 22);
            this.ToolStripMenuItemDecompilerAssemblies.Text = "Декомпилировать сборку";
            this.ToolStripMenuItemDecompilerAssemblies.Click += new System.EventHandler(this.ToolStripMenuItem_Click_DecompilerAssemblies);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem,
            this.ссылкаНаGitHubToolStripMenuItem});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            // 
            // ссылкаНаGitHubToolStripMenuItem
            // 
            this.ссылкаНаGitHubToolStripMenuItem.Name = "ссылкаНаGitHubToolStripMenuItem";
            this.ссылкаНаGitHubToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ссылкаНаGitHubToolStripMenuItem.Text = "Ссылка на GitHub";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 27);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(994, 719);
            this.listBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1111, 749);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDecompiler_EXE;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDecompilerDLL;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDecompilerAssemblies;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ссылкаНаGitHubToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox;
    }
}

