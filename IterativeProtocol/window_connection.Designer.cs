
namespace IterativeProtocol
{
    partial class window_connection
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
            this.copy_IP = new System.Windows.Forms.Button();
            this.label_current_IP = new System.Windows.Forms.Label();
            this.connect_to_correspondent = new System.Windows.Forms.Button();
            this.hint_1 = new System.Windows.Forms.Label();
            this.host_ip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // copy_IP
            // 
            this.copy_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copy_IP.Location = new System.Drawing.Point(471, 12);
            this.copy_IP.Name = "copy_IP";
            this.copy_IP.Size = new System.Drawing.Size(150, 35);
            this.copy_IP.TabIndex = 0;
            this.copy_IP.Text = "Скопировать IP";
            this.copy_IP.UseVisualStyleBackColor = true;
            this.copy_IP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_current_IP
            // 
            this.label_current_IP.AutoSize = true;
            this.label_current_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_current_IP.Location = new System.Drawing.Point(11, 12);
            this.label_current_IP.Name = "label_current_IP";
            this.label_current_IP.Size = new System.Drawing.Size(96, 29);
            this.label_current_IP.TabIndex = 1;
            this.label_current_IP.Text = "Ваш IP:";
            this.label_current_IP.Click += new System.EventHandler(this.label1_Click);
            // 
            // connect_to_correspondent
            // 
            this.connect_to_correspondent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connect_to_correspondent.Location = new System.Drawing.Point(471, 67);
            this.connect_to_correspondent.Name = "connect_to_correspondent";
            this.connect_to_correspondent.Size = new System.Drawing.Size(150, 35);
            this.connect_to_correspondent.TabIndex = 2;
            this.connect_to_correspondent.Text = "Подключиться";
            this.connect_to_correspondent.UseVisualStyleBackColor = true;
            this.connect_to_correspondent.Click += new System.EventHandler(this.button2_Click);
            // 
            // hint_1
            // 
            this.hint_1.AutoSize = true;
            this.hint_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint_1.Location = new System.Drawing.Point(12, 62);
            this.hint_1.Name = "hint_1";
            this.hint_1.Size = new System.Drawing.Size(420, 40);
            this.hint_1.TabIndex = 3;
            this.hint_1.Text = "Отправьте ваш IP корреспонденту и ждите\r\nзапрос на подключение или подключитесь с" +
    "ами";
            this.hint_1.Click += new System.EventHandler(this.label2_Click);
            // 
            // host_ip
            // 
            this.host_ip.AutoSize = true;
            this.host_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.host_ip.Location = new System.Drawing.Point(103, 12);
            this.host_ip.Name = "host_ip";
            this.host_ip.Size = new System.Drawing.Size(187, 29);
            this.host_ip.TabIndex = 4;
            this.host_ip.Text = "000.000.000.000";
            this.host_ip.Click += new System.EventHandler(this.host_ip_Click);
            // 
            // window_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 114);
            this.Controls.Add(this.host_ip);
            this.Controls.Add(this.hint_1);
            this.Controls.Add(this.connect_to_correspondent);
            this.Controls.Add(this.label_current_IP);
            this.Controls.Add(this.copy_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "window_connection";
            this.Text = "Iterative Protocol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copy_IP;
        private System.Windows.Forms.Label label_current_IP;
        private System.Windows.Forms.Button connect_to_correspondent;
        private System.Windows.Forms.Label hint_1;
        private System.Windows.Forms.Label host_ip;
    }
}

