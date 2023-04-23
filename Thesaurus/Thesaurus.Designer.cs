namespace Thesaurus
{
    partial class Thesaurus
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
            this.thesaurusView = new System.Windows.Forms.TreeView();
            this.download = new System.Windows.Forms.Button();
            this.getCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thesaurusView
            // 
            this.thesaurusView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thesaurusView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thesaurusView.Location = new System.Drawing.Point(12, 12);
            this.thesaurusView.Name = "thesaurusView";
            this.thesaurusView.Size = new System.Drawing.Size(758, 483);
            this.thesaurusView.TabIndex = 0;
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.download.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.download.Location = new System.Drawing.Point(12, 500);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(300, 40);
            this.download.TabIndex = 1;
            this.download.Text = "Прочитать понятия";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.Download_Click);
            // 
            // getCode
            // 
            this.getCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCode.Location = new System.Drawing.Point(470, 502);
            this.getCode.Name = "getCode";
            this.getCode.Size = new System.Drawing.Size(300, 39);
            this.getCode.TabIndex = 2;
            this.getCode.Text = "Узнать код понятия";
            this.getCode.UseVisualStyleBackColor = true;
            this.getCode.Click += new System.EventHandler(this.GetCode_Click);
            // 
            // Thesaurus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.getCode);
            this.Controls.Add(this.download);
            this.Controls.Add(this.thesaurusView);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Thesaurus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thesaurus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView thesaurusView;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button getCode;
    }
}

