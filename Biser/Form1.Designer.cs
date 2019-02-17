namespace Biser
{
    partial class Biser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biser));
            this.buttonActive1 = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonActive2 = new System.Windows.Forms.Button();
            this.buttonActive3 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.tbCols = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonActive1
            // 
            this.buttonActive1.BackColor = System.Drawing.Color.Black;
            this.buttonActive1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActive1.Location = new System.Drawing.Point(441, 12);
            this.buttonActive1.Name = "buttonActive1";
            this.buttonActive1.Size = new System.Drawing.Size(75, 23);
            this.buttonActive1.TabIndex = 1;
            this.buttonActive1.UseVisualStyleBackColor = false;
            this.buttonActive1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonActive_MouseClick);
            // 
            // buttonActive2
            // 
            this.buttonActive2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonActive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActive2.Location = new System.Drawing.Point(441, 41);
            this.buttonActive2.Name = "buttonActive2";
            this.buttonActive2.Size = new System.Drawing.Size(75, 23);
            this.buttonActive2.TabIndex = 1;
            this.buttonActive2.UseVisualStyleBackColor = false;
            this.buttonActive2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonActive_MouseClick);
            // 
            // buttonActive3
            // 
            this.buttonActive3.BackColor = System.Drawing.Color.White;
            this.buttonActive3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActive3.Location = new System.Drawing.Point(441, 70);
            this.buttonActive3.Name = "buttonActive3";
            this.buttonActive3.Size = new System.Drawing.Size(75, 23);
            this.buttonActive3.TabIndex = 1;
            this.buttonActive3.UseVisualStyleBackColor = false;
            this.buttonActive3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonActive_MouseClick);
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(12, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(424, 838);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // tbRows
            // 
            this.tbRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRows.Location = new System.Drawing.Point(441, 112);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(75, 20);
            this.tbRows.TabIndex = 3;
            this.tbRows.Text = "30";
            // 
            // tbCols
            // 
            this.tbCols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCols.Location = new System.Drawing.Point(442, 151);
            this.tbCols.Name = "tbCols";
            this.tbCols.Size = new System.Drawing.Size(75, 20);
            this.tbCols.TabIndex = 3;
            this.tbCols.Text = "20";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(441, 177);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 4;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columns";
            // 
            // Biser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(528, 862);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbCols);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonActive3);
            this.Controls.Add(this.buttonActive2);
            this.Controls.Add(this.buttonActive1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Biser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonActive1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonActive2;
        private System.Windows.Forms.Button buttonActive3;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.TextBox tbCols;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

