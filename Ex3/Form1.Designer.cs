namespace Ex3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			prgBar = new ProgressBar();
			btnRunANewTask = new Button();
			btnCancelTask = new Button();
			btnSave = new Button();
			lbxTaskResult = new ListBox();
			lbxData = new ListBox();
			txtMessage = new TextBox();
			SuspendLayout();
			// 
			// prgBar
			// 
			prgBar.Location = new Point(36, 88);
			prgBar.Name = "prgBar";
			prgBar.Size = new Size(193, 23);
			prgBar.TabIndex = 0;
			// 
			// btnRunANewTask
			// 
			btnRunANewTask.Location = new Point(36, 12);
			btnRunANewTask.Name = "btnRunANewTask";
			btnRunANewTask.Size = new Size(193, 23);
			btnRunANewTask.TabIndex = 1;
			btnRunANewTask.Text = "Ran A New Task";
			btnRunANewTask.UseVisualStyleBackColor = true;
			btnRunANewTask.Click += btnRunANewTask_Click;
			// 
			// btnCancelTask
			// 
			btnCancelTask.Location = new Point(36, 41);
			btnCancelTask.Name = "btnCancelTask";
			btnCancelTask.Size = new Size(193, 23);
			btnCancelTask.TabIndex = 2;
			btnCancelTask.Text = "Cancel Task";
			btnCancelTask.UseVisualStyleBackColor = true;
			btnCancelTask.Click += btnCancelTask_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(279, 88);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(120, 23);
			btnSave.TabIndex = 3;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// lbxTaskResult
			// 
			lbxTaskResult.FormattingEnabled = true;
			lbxTaskResult.ItemHeight = 15;
			lbxTaskResult.Location = new Point(36, 126);
			lbxTaskResult.Name = "lbxTaskResult";
			lbxTaskResult.Size = new Size(193, 244);
			lbxTaskResult.TabIndex = 4;
			// 
			// lbxData
			// 
			lbxData.FormattingEnabled = true;
			lbxData.ItemHeight = 15;
			lbxData.Location = new Point(279, 126);
			lbxData.Name = "lbxData";
			lbxData.Size = new Size(120, 244);
			lbxData.TabIndex = 5;
			// 
			// txtMessage
			// 
			txtMessage.Location = new Point(279, 42);
			txtMessage.Name = "txtMessage";
			txtMessage.Size = new Size(120, 23);
			txtMessage.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtMessage);
			Controls.Add(lbxData);
			Controls.Add(lbxTaskResult);
			Controls.Add(btnSave);
			Controls.Add(btnCancelTask);
			Controls.Add(btnRunANewTask);
			Controls.Add(prgBar);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ProgressBar prgBar;
		private Button btnRunANewTask;
		private Button btnCancelTask;
		private Button btnSave;
		private ListBox lbxTaskResult;
		private ListBox lbxData;
		private TextBox txtMessage;
	}
}