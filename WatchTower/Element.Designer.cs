namespace WatchTower
{
    partial class Element
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameNode = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameNode
            // 
            this.NameNode.AutoSize = true;
            this.NameNode.Location = new System.Drawing.Point(13, 25);
            this.NameNode.Name = "NameNode";
            this.NameNode.Size = new System.Drawing.Size(35, 13);
            this.NameNode.TabIndex = 0;
            this.NameNode.Text = "label1";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(95, 25);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(35, 13);
            this.IP.TabIndex = 1;
            this.IP.Text = "label2";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(206, 25);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 2;
            this.status.Text = "label3";
            // 
            // Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.status);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.NameNode);
            this.Name = "Element";
            this.Size = new System.Drawing.Size(266, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameNode;
        private System.Windows.Forms.Label IP;
        public System.Windows.Forms.Label status;
    }
}
