namespace shadowEditor
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
            this.tbHorizontal = new System.Windows.Forms.TrackBar();
            this.txtHorizontal = new System.Windows.Forms.TextBox();
            this.txtVertical = new System.Windows.Forms.TextBox();
            this.tbVertical = new System.Windows.Forms.TrackBar();
            this.txtBlur = new System.Windows.Forms.TextBox();
            this.tbBlur = new System.Windows.Forms.TrackBar();
            this.txtSpread = new System.Windows.Forms.TextBox();
            this.tbSpread = new System.Windows.Forms.TrackBar();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHorizontal
            // 
            this.tbHorizontal.Location = new System.Drawing.Point(57, 63);
            this.tbHorizontal.Maximum = 200;
            this.tbHorizontal.Minimum = -200;
            this.tbHorizontal.Name = "tbHorizontal";
            this.tbHorizontal.Size = new System.Drawing.Size(293, 56);
            this.tbHorizontal.TabIndex = 0;
            this.tbHorizontal.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtHorizontal
            // 
            this.txtHorizontal.Location = new System.Drawing.Point(366, 76);
            this.txtHorizontal.Name = "txtHorizontal";
            this.txtHorizontal.Size = new System.Drawing.Size(41, 22);
            this.txtHorizontal.TabIndex = 1;
            this.txtHorizontal.Text = "0";
            this.txtHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVertical
            // 
            this.txtVertical.Location = new System.Drawing.Point(366, 158);
            this.txtVertical.Name = "txtVertical";
            this.txtVertical.Size = new System.Drawing.Size(41, 22);
            this.txtVertical.TabIndex = 3;
            this.txtVertical.Text = "0";
            this.txtVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbVertical
            // 
            this.tbVertical.Location = new System.Drawing.Point(57, 145);
            this.tbVertical.Maximum = 200;
            this.tbVertical.Minimum = -200;
            this.tbVertical.Name = "tbVertical";
            this.tbVertical.Size = new System.Drawing.Size(293, 56);
            this.tbVertical.TabIndex = 2;
            this.tbVertical.Scroll += new System.EventHandler(this.tbVertical_Scroll);
            // 
            // txtBlur
            // 
            this.txtBlur.Location = new System.Drawing.Point(366, 233);
            this.txtBlur.Name = "txtBlur";
            this.txtBlur.Size = new System.Drawing.Size(41, 22);
            this.txtBlur.TabIndex = 5;
            this.txtBlur.Text = "0";
            this.txtBlur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBlur
            // 
            this.tbBlur.Location = new System.Drawing.Point(57, 220);
            this.tbBlur.Maximum = 200;
            this.tbBlur.Minimum = -200;
            this.tbBlur.Name = "tbBlur";
            this.tbBlur.Size = new System.Drawing.Size(293, 56);
            this.tbBlur.TabIndex = 4;
            this.tbBlur.Scroll += new System.EventHandler(this.tbBlur_Scroll);
            // 
            // txtSpread
            // 
            this.txtSpread.Location = new System.Drawing.Point(366, 295);
            this.txtSpread.Name = "txtSpread";
            this.txtSpread.Size = new System.Drawing.Size(41, 22);
            this.txtSpread.TabIndex = 7;
            this.txtSpread.Text = "0";
            this.txtSpread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSpread
            // 
            this.tbSpread.Location = new System.Drawing.Point(57, 282);
            this.tbSpread.Maximum = 200;
            this.tbSpread.Minimum = -200;
            this.tbSpread.Name = "tbSpread";
            this.tbSpread.Size = new System.Drawing.Size(293, 56);
            this.tbSpread.TabIndex = 6;
            this.tbSpread.Scroll += new System.EventHandler(this.tbSpread_Scroll);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(549, 23);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(482, 415);
            this.webView21.Source = new System.Uri("file:///C:/Users/meshm/OneDrive/Desktop/shadow%20editor%20web/sadowEditor.html", System.UriKind.Absolute);
            this.webView21.TabIndex = 8;
            this.webView21.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "px";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "px";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.txtSpread);
            this.Controls.Add(this.tbSpread);
            this.Controls.Add(this.txtBlur);
            this.Controls.Add(this.tbBlur);
            this.Controls.Add(this.txtVertical);
            this.Controls.Add(this.tbVertical);
            this.Controls.Add(this.txtHorizontal);
            this.Controls.Add(this.tbHorizontal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbHorizontal;
        private System.Windows.Forms.TextBox txtHorizontal;
        private System.Windows.Forms.TextBox txtVertical;
        private System.Windows.Forms.TrackBar tbVertical;
        private System.Windows.Forms.TextBox txtBlur;
        private System.Windows.Forms.TrackBar tbBlur;
        private System.Windows.Forms.TextBox txtSpread;
        private System.Windows.Forms.TrackBar tbSpread;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

