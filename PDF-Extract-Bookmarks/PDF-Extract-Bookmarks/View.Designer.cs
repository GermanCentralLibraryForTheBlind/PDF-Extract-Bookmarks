namespace PDF_Extract_Bookmarks
{
	partial class View
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
			this.tbxInput = new System.Windows.Forms.TextBox();
			this.tbxOutput1 = new System.Windows.Forms.TextBox();
			this.tbxOutput2 = new System.Windows.Forms.TextBox();
			this.grpInput = new System.Windows.Forms.GroupBox();
			this.btnInput = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExtract = new System.Windows.Forms.Button();
			this.lbResult = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.grpInput.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbxInput
			// 
			this.tbxInput.Location = new System.Drawing.Point(41, 43);
			this.tbxInput.Name = "tbxInput";
			this.tbxInput.Size = new System.Drawing.Size(698, 20);
			this.tbxInput.TabIndex = 0;
			// 
			// tbxOutput1
			// 
			this.tbxOutput1.Location = new System.Drawing.Point(41, 103);
			this.tbxOutput1.Name = "tbxOutput1";
			this.tbxOutput1.Size = new System.Drawing.Size(698, 20);
			this.tbxOutput1.TabIndex = 1;
			// 
			// tbxOutput2
			// 
			this.tbxOutput2.Location = new System.Drawing.Point(41, 164);
			this.tbxOutput2.Name = "tbxOutput2";
			this.tbxOutput2.Size = new System.Drawing.Size(698, 20);
			this.tbxOutput2.TabIndex = 2;
			// 
			// grpInput
			// 
			this.grpInput.Controls.Add(this.btnInput);
			this.grpInput.Location = new System.Drawing.Point(29, 25);
			this.grpInput.Name = "grpInput";
			this.grpInput.Size = new System.Drawing.Size(756, 48);
			this.grpInput.TabIndex = 3;
			this.grpInput.TabStop = false;
			this.grpInput.Text = "Input PDF";
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(716, 15);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(34, 23);
			this.btnInput.TabIndex = 0;
			this.btnInput.Text = "...";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.inputClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(29, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(756, 48);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "";
			this.groupBox1.Text = "Output HTML";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(29, 147);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(756, 48);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output XML";
			// 
			// btnExtract
			// 
			this.btnExtract.Location = new System.Drawing.Point(683, 219);
			this.btnExtract.Name = "btnExtract";
			this.btnExtract.Size = new System.Drawing.Size(102, 23);
			this.btnExtract.TabIndex = 5;
			this.btnExtract.Text = "Extract";
			this.btnExtract.UseVisualStyleBackColor = true;
			this.btnExtract.Click += new System.EventHandler(this.extractClick);
			// 
			// lbResult
			// 
			this.lbResult.AutoSize = true;
			this.lbResult.ForeColor = System.Drawing.Color.OliveDrab;
			this.lbResult.Location = new System.Drawing.Point(292, 224);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(0, 13);
			this.lbResult.TabIndex = 6;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 263);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.btnExtract);
			this.Controls.Add(this.tbxOutput2);
			this.Controls.Add(this.tbxOutput1);
			this.Controls.Add(this.tbxInput);
			this.Controls.Add(this.grpInput);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "View";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PDF-Extract-Bookmarks";
			this.grpInput.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbxInput;
		private System.Windows.Forms.TextBox tbxOutput1;
		private System.Windows.Forms.TextBox tbxOutput2;
		private System.Windows.Forms.GroupBox grpInput;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.Label lbResult;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

