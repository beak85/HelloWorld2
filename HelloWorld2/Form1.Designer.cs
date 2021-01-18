
namespace HelloWorld2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.lblDisplayInfo = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.picPC = new System.Windows.Forms.PictureBox();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.btnHidePic = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(174, 89);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(87, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Say Hello";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // lblDisplayInfo
            // 
            this.lblDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayInfo.Location = new System.Drawing.Point(41, 42);
            this.lblDisplayInfo.Name = "lblDisplayInfo";
            this.lblDisplayInfo.Size = new System.Drawing.Size(220, 26);
            this.lblDisplayInfo.TabIndex = 1;
            this.lblDisplayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(41, 89);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(127, 23);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "Display Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(41, 118);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(127, 23);
            this.btnGoodbye.TabIndex = 3;
            this.btnGoodbye.Text = "Say Goodbye";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // picPC
            // 
            this.picPC.Image = ((System.Drawing.Image)(resources.GetObject("picPC.Image")));
            this.picPC.Location = new System.Drawing.Point(297, 42);
            this.picPC.Name = "picPC";
            this.picPC.Size = new System.Drawing.Size(222, 153);
            this.picPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPC.TabIndex = 4;
            this.picPC.TabStop = false;
            this.picPC.Visible = false;
            this.picPC.Click += new System.EventHandler(this.picPC_Click);
            // 
            // btnShowPic
            // 
            this.btnShowPic.Location = new System.Drawing.Point(41, 147);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(127, 23);
            this.btnShowPic.TabIndex = 5;
            this.btnShowPic.Text = "Show Pic";
            this.btnShowPic.UseVisualStyleBackColor = true;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // btnHidePic
            // 
            this.btnHidePic.Location = new System.Drawing.Point(175, 146);
            this.btnHidePic.Name = "btnHidePic";
            this.btnHidePic.Size = new System.Drawing.Size(75, 23);
            this.btnHidePic.TabIndex = 6;
            this.btnHidePic.Text = "Hide Pic";
            this.btnHidePic.UseVisualStyleBackColor = true;
            this.btnHidePic.Click += new System.EventHandler(this.btnHidePic_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(175, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 226);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHidePic);
            this.Controls.Add(this.btnShowPic);
            this.Controls.Add(this.picPC);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lblDisplayInfo);
            this.Controls.Add(this.btnHelloWorld);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Hello World";
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Label lblDisplayInfo;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnGoodbye;
        private System.Windows.Forms.PictureBox picPC;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.Button btnHidePic;
        private System.Windows.Forms.Button btnClose;
    }
}

