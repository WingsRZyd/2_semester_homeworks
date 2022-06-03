namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxWheels = new System.Windows.Forms.ComboBox();
            this.labelWheels = new System.Windows.Forms.Label();
            this.comboBoxCarBody = new System.Windows.Forms.ComboBox();
            this.labelCarBody = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Your_Car = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1104, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxWheels
            // 
            this.comboBoxWheels.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxWheels.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxWheels.FormattingEnabled = true;
            this.comboBoxWheels.Location = new System.Drawing.Point(71, 85);
            this.comboBoxWheels.Name = "comboBoxWheels";
            this.comboBoxWheels.Size = new System.Drawing.Size(242, 79);
            this.comboBoxWheels.TabIndex = 1;
            // 
            // labelWheels
            // 
            this.labelWheels.AutoSize = true;
            this.labelWheels.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWheels.Location = new System.Drawing.Point(71, 25);
            this.labelWheels.Name = "labelWheels";
            this.labelWheels.Size = new System.Drawing.Size(244, 51);
            this.labelWheels.TabIndex = 2;
            this.labelWheels.Text = "Тип привода";
            this.labelWheels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCarBody
            // 
            this.comboBoxCarBody.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCarBody.FormattingEnabled = true;
            this.comboBoxCarBody.Location = new System.Drawing.Point(368, 85);
            this.comboBoxCarBody.Name = "comboBoxCarBody";
            this.comboBoxCarBody.Size = new System.Drawing.Size(261, 79);
            this.comboBoxCarBody.TabIndex = 1;
            this.comboBoxCarBody.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarBody_SelectedIndexChanged);
            // 
            // labelCarBody
            // 
            this.labelCarBody.AutoSize = true;
            this.labelCarBody.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCarBody.Location = new System.Drawing.Point(390, 25);
            this.labelCarBody.Name = "labelCarBody";
            this.labelCarBody.Size = new System.Drawing.Size(211, 51);
            this.labelCarBody.TabIndex = 2;
            this.labelCarBody.Text = "Тип кузова";
            this.labelCarBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(719, 85);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(242, 79);
            this.comboBoxCountry.TabIndex = 1;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(641, 25);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(424, 51);
            this.labelCountry.TabIndex = 2;
            this.labelCountry.Text = "Страна-производитель";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(2825, 2000);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Your_Car
            // 
            this.Your_Car.AutoSize = true;
            this.Your_Car.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Your_Car.Location = new System.Drawing.Point(1460, 81);
            this.Your_Car.Name = "Your_Car";
            this.Your_Car.Size = new System.Drawing.Size(0, 54);
            this.Your_Car.TabIndex = 6;
            this.Your_Car.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1849, 890);
            this.Controls.Add(this.Your_Car);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelCarBody);
            this.Controls.Add(this.labelWheels);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxCarBody);
            this.Controls.Add(this.comboBoxWheels);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxWheels;
        private Label labelWheels;
        private ComboBox comboBoxCarBody;
        private Label labelCarBody;
        private ComboBox comboBoxCountry;
        private Label labelCountry;
        private DataGridView dataGridView1;
        private Label Your_Car;
    }
}