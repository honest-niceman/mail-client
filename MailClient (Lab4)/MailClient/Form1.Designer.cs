namespace MailClient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_Atch = new System.Windows.Forms.Button();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.textBox_Sub = new System.Windows.Forms.TextBox();
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SMTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.listBox_Attachments = new System.Windows.Forms.ListBox();
            this.listBox_Recievers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(91, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кому";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(89, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тема";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(91, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вложения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(476, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Текст";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_Atch
            // 
            this.button_Atch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Atch.Location = new System.Drawing.Point(268, 621);
            this.button_Atch.Name = "button_Atch";
            this.button_Atch.Size = new System.Drawing.Size(172, 43);
            this.button_Atch.TabIndex = 8;
            this.button_Atch.Text = "Прикрепить";
            this.button_Atch.UseVisualStyleBackColor = true;
            this.button_Atch.Click += new System.EventHandler(this.button_Atch_Click);
            // 
            // textBox_To
            // 
            this.textBox_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_To.Location = new System.Drawing.Point(273, 162);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(354, 35);
            this.textBox_To.TabIndex = 9;
            this.textBox_To.Text = "subardinatia@gmail.com";
            // 
            // textBox_Sub
            // 
            this.textBox_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Sub.Location = new System.Drawing.Point(273, 216);
            this.textBox_Sub.Name = "textBox_Sub";
            this.textBox_Sub.Size = new System.Drawing.Size(354, 35);
            this.textBox_Sub.TabIndex = 10;
            this.textBox_Sub.Text = "Test";
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Msg.Location = new System.Drawing.Point(471, 306);
            this.textBox_Msg.Multiline = true;
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.Size = new System.Drawing.Size(353, 304);
            this.textBox_Msg.TabIndex = 12;
            this.textBox_Msg.Text = "ТЕСТТЕСТТЕСТТЕСТТЕСТ";
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Send.Location = new System.Drawing.Point(652, 621);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(172, 43);
            this.button_Send.TabIndex = 13;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(91, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "SMTP сервер:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_SMTP
            // 
            this.textBox_SMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_SMTP.Location = new System.Drawing.Point(283, 22);
            this.textBox_SMTP.Name = "textBox_SMTP";
            this.textBox_SMTP.Size = new System.Drawing.Size(120, 26);
            this.textBox_SMTP.TabIndex = 15;
            this.textBox_SMTP.Text = "smtp.gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(511, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Port";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_Port.Location = new System.Drawing.Point(574, 22);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(63, 26);
            this.textBox_Port.TabIndex = 17;
            this.textBox_Port.Text = "587";
            // 
            // listBox_Attachments
            // 
            this.listBox_Attachments.FormattingEnabled = true;
            this.listBox_Attachments.ItemHeight = 20;
            this.listBox_Attachments.Location = new System.Drawing.Point(96, 306);
            this.listBox_Attachments.Name = "listBox_Attachments";
            this.listBox_Attachments.Size = new System.Drawing.Size(344, 304);
            this.listBox_Attachments.TabIndex = 18;
            // 
            // listBox_Recievers
            // 
            this.listBox_Recievers.FormattingEnabled = true;
            this.listBox_Recievers.ItemHeight = 20;
            this.listBox_Recievers.Location = new System.Drawing.Point(858, 306);
            this.listBox_Recievers.Name = "listBox_Recievers";
            this.listBox_Recievers.Size = new System.Drawing.Size(344, 304);
            this.listBox_Recievers.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(686, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить получателя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(853, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Список Получателей";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(91, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Логин:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Login.Location = new System.Drawing.Point(186, 68);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(320, 35);
            this.textBox_Login.TabIndex = 23;
            this.textBox_Login.Text = "megamozg930@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(538, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Пароль";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Password.Location = new System.Drawing.Point(643, 68);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(181, 35);
            this.textBox_Password.TabIndex = 25;
            this.textBox_Password.Text = "DEFdckhiHjrJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1285, 702);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Recievers);
            this.Controls.Add(this.listBox_Attachments);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_SMTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Msg);
            this.Controls.Add(this.textBox_Sub);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.button_Atch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laba4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_Atch;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.TextBox textBox_Sub;
        private System.Windows.Forms.TextBox textBox_Msg;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.ListBox listBox_Attachments;
        private System.Windows.Forms.ListBox listBox_Recievers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}

