
namespace VehicleGame
{
    partial class FormGame
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNotice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAmbulance = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelicopter = new System.Windows.Forms.PictureBox();
            this.pictureBoxMotorcycle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbulance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelicopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorcycle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNotice.ForeColor = System.Drawing.Color.Red;
            this.labelNotice.Location = new System.Drawing.Point(93, 13);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(52, 16);
            this.labelNotice.TabIndex = 1;
            this.labelNotice.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleGame.Properties.Resources.accident;
            this.pictureBox1.Location = new System.Drawing.Point(930, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAmbulance
            // 
            this.pictureBoxAmbulance.Image = global::VehicleGame.Properties.Resources.ambulance;
            this.pictureBoxAmbulance.Location = new System.Drawing.Point(12, 370);
            this.pictureBoxAmbulance.Name = "pictureBoxAmbulance";
            this.pictureBoxAmbulance.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxAmbulance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAmbulance.TabIndex = 4;
            this.pictureBoxAmbulance.TabStop = false;
            // 
            // pictureBoxHelicopter
            // 
            this.pictureBoxHelicopter.Image = global::VehicleGame.Properties.Resources.helicopter;
            this.pictureBoxHelicopter.Location = new System.Drawing.Point(12, 370);
            this.pictureBoxHelicopter.Name = "pictureBoxHelicopter";
            this.pictureBoxHelicopter.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxHelicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHelicopter.TabIndex = 3;
            this.pictureBoxHelicopter.TabStop = false;
            // 
            // pictureBoxMotorcycle
            // 
            this.pictureBoxMotorcycle.Image = global::VehicleGame.Properties.Resources.motorcycle;
            this.pictureBoxMotorcycle.Location = new System.Drawing.Point(12, 358);
            this.pictureBoxMotorcycle.Name = "pictureBoxMotorcycle";
            this.pictureBoxMotorcycle.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxMotorcycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMotorcycle.TabIndex = 2;
            this.pictureBoxMotorcycle.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAmbulance);
            this.Controls.Add(this.pictureBoxHelicopter);
            this.Controls.Add(this.pictureBoxMotorcycle);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbulance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelicopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorcycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.PictureBox pictureBoxMotorcycle;
        private System.Windows.Forms.PictureBox pictureBoxHelicopter;
        private System.Windows.Forms.PictureBox pictureBoxAmbulance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

