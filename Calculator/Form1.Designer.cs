
namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.textBoxEqual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxActivity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxActivity.Enabled = false;
            this.textBoxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxActivity.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxActivity.Location = new System.Drawing.Point(5, 5);
            this.textBoxActivity.Multiline = true;
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.Size = new System.Drawing.Size(375, 20);
            this.textBoxActivity.TabIndex = 0;
            this.textBoxActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEqual
            // 
            this.textBoxEqual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEqual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxEqual.Enabled = false;
            this.textBoxEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEqual.ForeColor = System.Drawing.Color.Black;
            this.textBoxEqual.Location = new System.Drawing.Point(5, 32);
            this.textBoxEqual.Name = "textBoxEqual";
            this.textBoxEqual.Size = new System.Drawing.Size(375, 62);
            this.textBoxEqual.TabIndex = 0;
            this.textBoxEqual.Text = "0";
            this.textBoxEqual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.textBoxEqual);
            this.Controls.Add(this.textBoxActivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.TextBox textBoxEqual;
    }
}

