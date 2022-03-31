
namespace EyeTrackingTest
{
    partial class Form1
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
            this.PicCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.TxtPersonName = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecogonize = new System.Windows.Forms.Button();
            this.picDectected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDectected)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCapture
            // 
            this.PicCapture.Location = new System.Drawing.Point(12, 12);
            this.PicCapture.Name = "PicCapture";
            this.PicCapture.Size = new System.Drawing.Size(642, 411);
            this.PicCapture.TabIndex = 0;
            this.PicCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(660, 13);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(128, 39);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(661, 59);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(127, 34);
            this.btnDetectFaces.TabIndex = 2;
            this.btnDetectFaces.Text = "Detect Faces";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            // 
            // TxtPersonName
            // 
            this.TxtPersonName.Location = new System.Drawing.Point(661, 246);
            this.TxtPersonName.Name = "TxtPersonName";
            this.TxtPersonName.Size = new System.Drawing.Size(127, 20);
            this.TxtPersonName.TabIndex = 3;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(661, 272);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(127, 31);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(661, 310);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(127, 33);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Train Image";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // btnRecogonize
            // 
            this.btnRecogonize.Location = new System.Drawing.Point(661, 349);
            this.btnRecogonize.Name = "btnRecogonize";
            this.btnRecogonize.Size = new System.Drawing.Size(127, 33);
            this.btnRecogonize.TabIndex = 6;
            this.btnRecogonize.Text = "Recognize";
            this.btnRecogonize.UseVisualStyleBackColor = true;
            // 
            // picDectected
            // 
            this.picDectected.Location = new System.Drawing.Point(661, 99);
            this.picDectected.Name = "picDectected";
            this.picDectected.Size = new System.Drawing.Size(127, 141);
            this.picDectected.TabIndex = 7;
            this.picDectected.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDectected);
            this.Controls.Add(this.btnRecogonize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.TxtPersonName);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.PicCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDectected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.TextBox TxtPersonName;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecogonize;
        private System.Windows.Forms.PictureBox picDectected;
    }
}

