namespace myTyping
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
            this.laQues = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laRemain = new System.Windows.Forms.Label();
            this.laResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // laQues
            // 
            this.laQues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laQues.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.laQues.Location = new System.Drawing.Point(6, 196);
            this.laQues.Name = "laQues";
            this.laQues.Size = new System.Drawing.Size(764, 27);
            this.laQues.TabIndex = 0;
            this.laQues.Text = "tlQ";
            this.laQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.tbInput.Location = new System.Drawing.Point(6, 307);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(764, 34);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.laRemain);
            this.groupBox1.Controls.Add(this.laResult);
            this.groupBox1.Controls.Add(this.laQues);
            this.groupBox1.Controls.Add(this.tbInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // laRemain
            // 
            this.laRemain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laRemain.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.laRemain.Location = new System.Drawing.Point(6, 39);
            this.laRemain.Name = "laRemain";
            this.laRemain.Size = new System.Drawing.Size(764, 27);
            this.laRemain.TabIndex = 3;
            this.laRemain.Text = "tlQ";
            this.laRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laResult
            // 
            this.laResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laResult.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.laResult.Location = new System.Drawing.Point(6, 91);
            this.laResult.Name = "laResult";
            this.laResult.Size = new System.Drawing.Size(764, 27);
            this.laResult.TabIndex = 2;
            this.laResult.Text = "tlQ";
            this.laResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laQues;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label laRemain;
        private System.Windows.Forms.Label laResult;
    }
}

