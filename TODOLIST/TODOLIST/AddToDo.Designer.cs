namespace TODOLIST
{
	partial class AddToDo
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
			this.butAdd = new System.Windows.Forms.Button();
			this.butExit = new System.Windows.Forms.Button();
			this.textTodo = new System.Windows.Forms.TextBox();
			this.checkBoxDone = new System.Windows.Forms.CheckBox();
			this.labelThingtodo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// butAdd
			// 
			this.butAdd.Location = new System.Drawing.Point(297, 98);
			this.butAdd.Name = "butAdd";
			this.butAdd.Size = new System.Drawing.Size(75, 23);
			this.butAdd.TabIndex = 0;
			this.butAdd.Text = "Add";
			this.butAdd.UseVisualStyleBackColor = true;
			this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
			// 
			// butExit
			// 
			this.butExit.Location = new System.Drawing.Point(392, 98);
			this.butExit.Name = "butExit";
			this.butExit.Size = new System.Drawing.Size(75, 23);
			this.butExit.TabIndex = 0;
			this.butExit.Text = "Exit";
			this.butExit.UseVisualStyleBackColor = true;
			// 
			// textTodo
			// 
			this.textTodo.Location = new System.Drawing.Point(28, 59);
			this.textTodo.Name = "textTodo";
			this.textTodo.Size = new System.Drawing.Size(344, 20);
			this.textTodo.TabIndex = 1;
			// 
			// checkBoxDone
			// 
			this.checkBoxDone.AutoSize = true;
			this.checkBoxDone.Location = new System.Drawing.Point(392, 62);
			this.checkBoxDone.Name = "checkBoxDone";
			this.checkBoxDone.Size = new System.Drawing.Size(52, 17);
			this.checkBoxDone.TabIndex = 2;
			this.checkBoxDone.Text = "Done";
			this.checkBoxDone.UseVisualStyleBackColor = true;
			// 
			// labelThingtodo
			// 
			this.labelThingtodo.AutoSize = true;
			this.labelThingtodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelThingtodo.Location = new System.Drawing.Point(124, 9);
			this.labelThingtodo.Name = "labelThingtodo";
			this.labelThingtodo.Size = new System.Drawing.Size(179, 37);
			this.labelThingtodo.TabIndex = 3;
			this.labelThingtodo.Text = "Thing to do";
			// 
			// AddToDo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 133);
			this.Controls.Add(this.labelThingtodo);
			this.Controls.Add(this.checkBoxDone);
			this.Controls.Add(this.textTodo);
			this.Controls.Add(this.butExit);
			this.Controls.Add(this.butAdd);
			this.Name = "AddToDo";
			this.Text = "Add To Do";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button butAdd;
		private System.Windows.Forms.Button butExit;
		private System.Windows.Forms.TextBox textTodo;
		private System.Windows.Forms.CheckBox checkBoxDone;
		private System.Windows.Forms.Label labelThingtodo;
	}
}