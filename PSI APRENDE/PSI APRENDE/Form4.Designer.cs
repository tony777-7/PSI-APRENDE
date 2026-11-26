namespace PSI_APRENDE
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(386, 28);
            label1.TabIndex = 0;
            label1.Text = "SEGUIMIENTO DE ATENCIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 76);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Buscar Paciente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(968, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 163);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 3;
            label3.Text = "Fecha de sesion";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(51, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(383, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(567, 163);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 5;
            label4.Text = "Tipo de atencion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(567, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(448, 27);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(567, 237);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 7;
            label5.Text = "Estado de seguimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 237);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 8;
            label6.Text = "Profesional";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(567, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(51, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(383, 27);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 326);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 11;
            label7.Text = "Actividad realizada";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(47, 361);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(968, 27);
            textBox5.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(590, 422);
            button2.Name = "button2";
            button2.Size = new Size(347, 48);
            button2.TabIndex = 14;
            button2.Text = "Consultar historial";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(76, 422);
            button1.Name = "button1";
            button1.Size = new Size(347, 48);
            button1.TabIndex = 15;
            button1.Text = "Guardar sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 482);
            label8.Name = "label8";
            label8.Size = new Size(291, 25);
            label8.TabIndex = 16;
            label8.Text = "Historial de sesiones del paciente";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Tipo, Estado });
            dataGridView1.Location = new Point(37, 520);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1033, 200);
            dataGridView1.TabIndex = 17;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 732);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Seguimiento de Atenciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Button button2;
        private Button button1;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Estado;
    }
}