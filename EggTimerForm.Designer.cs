namespace EggTimer {
    partial class EggTimerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(12, 12);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(250, 80);
            this.timeTextBox.TabIndex = 1;
            this.timeTextBox.Text = "03:00";
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeTextBox_KeyPress);
            // 
            // actionButton
            // 
            this.actionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionButton.Location = new System.Drawing.Point(12, 100);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(250, 80);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "Start";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // EggTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.timeTextBox);
            this.Name = "EggTimerForm";
            this.Text = "Egg Timer";
            this.Load += new System.EventHandler(this.EggTimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button actionButton;
    }
}

