namespace DificuldadeClique
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
            label1 = new Label();
            bntSim = new Button();
            bntNao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 115);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "Deseja confirmar a ação?";
            // 
            // bntSim
            // 
            bntSim.Cursor = Cursors.Hand;
            bntSim.Location = new Point(242, 201);
            bntSim.Name = "bntSim";
            bntSim.Size = new Size(112, 34);
            bntSim.TabIndex = 1;
            bntSim.Text = "Sim";
            bntSim.UseVisualStyleBackColor = true;
            bntSim.Click += button1_Click;
            // 
            // bntNao
            // 
            bntNao.Cursor = Cursors.Hand;
            bntNao.Location = new Point(473, 201);
            bntNao.Name = "bntNao";
            bntNao.Size = new Size(112, 34);
            bntNao.TabIndex = 2;
            bntNao.Text = "Não";
            bntNao.UseVisualStyleBackColor = true;
            bntNao.MouseMove += bntNao_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntNao);
            Controls.Add(bntSim);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bntSim;
        private Button bntNao;
    }
}
