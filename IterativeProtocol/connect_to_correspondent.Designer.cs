
namespace IterativeProtocol
{
    partial class connect_to_correspondent
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
            this.components = new System.ComponentModel.Container();
            this.label_of_IP_area = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label_of_IP_area
            // 
            this.label_of_IP_area.AutoSize = true;
            this.label_of_IP_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_of_IP_area.Location = new System.Drawing.Point(15, 15);
            this.label_of_IP_area.Name = "label_of_IP_area";
            this.label_of_IP_area.Size = new System.Drawing.Size(343, 29);
            this.label_of_IP_area.TabIndex = 0;
            this.label_of_IP_area.Text = "Введите IP корреспондента:";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(110, 100);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(153, 47);
            this.connect.TabIndex = 1;
            this.connect.Text = "Подключиться";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(20, 60);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(338, 34);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // connect_to_correspondent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label_of_IP_area);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "connect_to_correspondent";
            this.Text = "Подключение к корреспонденту";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.connect_to_correspondent_FormClosed);
            this.Load += new System.EventHandler(this.connect_to_correspondent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_of_IP_area;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}