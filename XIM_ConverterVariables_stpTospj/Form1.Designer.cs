namespace XIM_ConverterVariables_stpTospj
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
            txt_Promp = new TextBox();
            txt_Result = new TextBox();
            btn_Convert = new Button();
            btn_Clean = new Button();
            groupBox1 = new GroupBox();
            rb_TipoB = new RadioButton();
            rb_TipoA = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Promp
            // 
            txt_Promp.Location = new Point(56, 34);
            txt_Promp.Multiline = true;
            txt_Promp.Name = "txt_Promp";
            txt_Promp.Size = new Size(693, 133);
            txt_Promp.TabIndex = 0;
            // 
            // txt_Result
            // 
            txt_Result.Location = new Point(56, 217);
            txt_Result.Multiline = true;
            txt_Result.Name = "txt_Result";
            txt_Result.Size = new Size(693, 133);
            txt_Result.TabIndex = 1;
            // 
            // btn_Convert
            // 
            btn_Convert.Location = new Point(637, 377);
            btn_Convert.Name = "btn_Convert";
            btn_Convert.Size = new Size(112, 34);
            btn_Convert.TabIndex = 2;
            btn_Convert.Text = "Convertir";
            btn_Convert.UseVisualStyleBackColor = true;
            btn_Convert.Click += btn_Convert_Click;
            // 
            // btn_Clean
            // 
            btn_Clean.Location = new Point(507, 377);
            btn_Clean.Name = "btn_Clean";
            btn_Clean.Size = new Size(112, 34);
            btn_Clean.TabIndex = 3;
            btn_Clean.Text = "Limpiar";
            btn_Clean.UseVisualStyleBackColor = true;
            btn_Clean.Click += btn_Clean_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_TipoB);
            groupBox1.Controls.Add(rb_TipoA);
            groupBox1.Location = new Point(56, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 65);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo conversión";
            // 
            // rb_TipoB
            // 
            rb_TipoB.AutoSize = true;
            rb_TipoB.Location = new Point(153, 30);
            rb_TipoB.Name = "rb_TipoB";
            rb_TipoB.Size = new Size(87, 29);
            rb_TipoB.TabIndex = 1;
            rb_TipoB.TabStop = true;
            rb_TipoB.Text = "Tipo B";
            rb_TipoB.UseVisualStyleBackColor = true;
            rb_TipoB.CheckedChanged += rb_TipoB_CheckedChanged;
            // 
            // rb_TipoA
            // 
            rb_TipoA.AutoSize = true;
            rb_TipoA.Checked = true;
            rb_TipoA.Location = new Point(6, 30);
            rb_TipoA.Name = "rb_TipoA";
            rb_TipoA.Size = new Size(89, 29);
            rb_TipoA.TabIndex = 0;
            rb_TipoA.TabStop = true;
            rb_TipoA.Text = "Tipo A";
            rb_TipoA.UseVisualStyleBackColor = true;
            rb_TipoA.CheckedChanged += rb_TipoA_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btn_Clean);
            Controls.Add(btn_Convert);
            Controls.Add(txt_Result);
            Controls.Add(txt_Promp);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Promp;
        private TextBox txt_Result;
        private Button btn_Convert;
        private Button btn_Clean;
        private GroupBox groupBox1;
        private RadioButton rb_TipoB;
        private RadioButton rb_TipoA;
    }
}