namespace Target_Questions
{
	partial class Interface
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
			Button_Fibonacci = new Button();
			Button_StringHasA = new Button();
			Label_StringHasA = new Label();
			Label_Fibonacci = new Label();
			TextBox_Fibonacci = new TextBox();
			TextBox_StringHasA = new TextBox();
			Hint_Fibonacci = new Label();
			Hint_StringHasA = new Label();
			label5 = new Label();
			Return_StringHasA = new Label();
			Return_Fibonacci = new Label();
			SuspendLayout();
			// 
			// Button_Fibonacci
			// 
			Button_Fibonacci.Location = new Point(200, 53);
			Button_Fibonacci.Name = "Button_Fibonacci";
			Button_Fibonacci.Size = new Size(75, 23);
			Button_Fibonacci.TabIndex = 0;
			Button_Fibonacci.Text = "Enviar\r\n";
			Button_Fibonacci.UseVisualStyleBackColor = true;
			Button_Fibonacci.Click += Button_Fibonacci_Click;
			// 
			// Button_StringHasA
			// 
			Button_StringHasA.Location = new Point(200, 193);
			Button_StringHasA.Name = "Button_StringHasA";
			Button_StringHasA.Size = new Size(75, 23);
			Button_StringHasA.TabIndex = 1;
			Button_StringHasA.Text = "Enviar\r\n\r\n\r\n";
			Button_StringHasA.UseVisualStyleBackColor = true;
			Button_StringHasA.Click += Button_StringHasA_Click;
			// 
			// Label_StringHasA
			// 
			Label_StringHasA.AutoSize = true;
			Label_StringHasA.Location = new Point(30, 175);
			Label_StringHasA.Name = "Label_StringHasA";
			Label_StringHasA.Size = new Size(124, 15);
			Label_StringHasA.TabIndex = 4;
			Label_StringHasA.Text = "2) String com a letra A";
			// 
			// Label_Fibonacci
			// 
			Label_Fibonacci.AutoSize = true;
			Label_Fibonacci.Location = new Point(30, 36);
			Label_Fibonacci.Name = "Label_Fibonacci";
			Label_Fibonacci.Size = new Size(134, 15);
			Label_Fibonacci.TabIndex = 5;
			Label_Fibonacci.Text = "1) Número de Fibonacci";
			// 
			// TextBox_Fibonacci
			// 
			TextBox_Fibonacci.Location = new Point(30, 54);
			TextBox_Fibonacci.Name = "TextBox_Fibonacci";
			TextBox_Fibonacci.Size = new Size(146, 23);
			TextBox_Fibonacci.TabIndex = 6;
			// 
			// TextBox_StringHasA
			// 
			TextBox_StringHasA.Location = new Point(30, 194);
			TextBox_StringHasA.Name = "TextBox_StringHasA";
			TextBox_StringHasA.Size = new Size(146, 23);
			TextBox_StringHasA.TabIndex = 7;
			TextBox_StringHasA.Text = " ";
			// 
			// Hint_Fibonacci
			// 
			Hint_Fibonacci.AutoSize = true;
			Hint_Fibonacci.Location = new Point(30, 92);
			Hint_Fibonacci.Name = "Hint_Fibonacci";
			Hint_Fibonacci.Size = new Size(318, 15);
			Hint_Fibonacci.TabIndex = 8;
			Hint_Fibonacci.Text = "Verifica se o numéro está dentro da sequência de Fibonacci";
			// 
			// Hint_StringHasA
			// 
			Hint_StringHasA.AutoSize = true;
			Hint_StringHasA.Location = new Point(30, 234);
			Hint_StringHasA.Name = "Hint_StringHasA";
			Hint_StringHasA.Size = new Size(333, 15);
			Hint_StringHasA.TabIndex = 9;
			Hint_StringHasA.Text = "Verifica se a string contém a letra A, e quantas vezes ela repete";
			// 
			// label5
			// 
			label5.Location = new Point(0, 0);
			label5.Name = "label5";
			label5.Size = new Size(100, 23);
			label5.TabIndex = 13;
			// 
			// Return_StringHasA
			// 
			Return_StringHasA.AutoSize = true;
			Return_StringHasA.Location = new Point(299, 197);
			Return_StringHasA.Name = "Return_StringHasA";
			Return_StringHasA.Size = new Size(142, 15);
			Return_StringHasA.TabIndex = 11;
			Return_StringHasA.Text = "A resposta aparecerá aqui";
			// 
			// Return_Fibonacci
			// 
			Return_Fibonacci.AutoSize = true;
			Return_Fibonacci.Location = new Point(293, 57);
			Return_Fibonacci.Name = "Return_Fibonacci";
			Return_Fibonacci.Size = new Size(142, 15);
			Return_Fibonacci.TabIndex = 12;
			Return_Fibonacci.Text = "A resposta aparecerá aqui";
			// 
			// Interface
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Return_Fibonacci);
			Controls.Add(Return_StringHasA);
			Controls.Add(label5);
			Controls.Add(Hint_StringHasA);
			Controls.Add(Hint_Fibonacci);
			Controls.Add(TextBox_StringHasA);
			Controls.Add(TextBox_Fibonacci);
			Controls.Add(Label_Fibonacci);
			Controls.Add(Label_StringHasA);
			Controls.Add(Button_StringHasA);
			Controls.Add(Button_Fibonacci);
			Name = "Interface";
			Text = "Target Questions";
			Load += Interface_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button Button_Fibonacci;
		private Button Button_StringHasA;
		private Label Label_StringHasA;
		private Label Label_Fibonacci;
		private TextBox TextBox_Fibonacci;
		private TextBox TextBox_StringHasA;
		private Label Hint_Fibonacci;
		private Label Hint_StringHasA;
		private Label label5;
		private Label Return_StringHasA;
		private Label Return_Fibonacci;
	}
}
