namespace Calendario
{
    partial class AgregarEventos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHoraRecordatorio = new System.Windows.Forms.ComboBox();
            this.pickerRecordatorio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecordatorio = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcionTarea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHoraTarea = new System.Windows.Forms.ComboBox();
            this.pickerTarea = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnGuardarRecordatorio = new System.Windows.Forms.Button();
            this.btnGuardarTarea = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 331);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardarRecordatorio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbHoraRecordatorio);
            this.tabPage1.Controls.Add(this.pickerRecordatorio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRecordatorio);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recordatorios";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbHoraRecordatorio
            // 
            this.cmbHoraRecordatorio.FormattingEnabled = true;
            this.cmbHoraRecordatorio.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cmbHoraRecordatorio.Location = new System.Drawing.Point(243, 133);
            this.cmbHoraRecordatorio.Name = "cmbHoraRecordatorio";
            this.cmbHoraRecordatorio.Size = new System.Drawing.Size(171, 26);
            this.cmbHoraRecordatorio.TabIndex = 3;
            this.cmbHoraRecordatorio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pickerRecordatorio
            // 
            this.pickerRecordatorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerRecordatorio.Location = new System.Drawing.Point(58, 135);
            this.pickerRecordatorio.Name = "pickerRecordatorio";
            this.pickerRecordatorio.Size = new System.Drawing.Size(155, 24);
            this.pickerRecordatorio.TabIndex = 2;
            this.pickerRecordatorio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa el titulo del recordatorio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRecordatorio
            // 
            this.txtRecordatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordatorio.Location = new System.Drawing.Point(59, 63);
            this.txtRecordatorio.MaxLength = 40;
            this.txtRecordatorio.Name = "txtRecordatorio";
            this.txtRecordatorio.Size = new System.Drawing.Size(356, 24);
            this.txtRecordatorio.TabIndex = 0;
            this.txtRecordatorio.TextChanged += new System.EventHandler(this.txtRecordatorio_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarTarea);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtDescripcionTarea);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbHoraTarea);
            this.tabPage2.Controls.Add(this.pickerTarea);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtTarea);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tareas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionTarea.Location = new System.Drawing.Point(58, 150);
            this.txtDescripcionTarea.MaxLength = 299;
            this.txtDescripcionTarea.Multiline = true;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(356, 84);
            this.txtDescripcionTarea.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dia";
            // 
            // cmbHoraTarea
            // 
            this.cmbHoraTarea.FormattingEnabled = true;
            this.cmbHoraTarea.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cmbHoraTarea.Location = new System.Drawing.Point(243, 91);
            this.cmbHoraTarea.Name = "cmbHoraTarea";
            this.cmbHoraTarea.Size = new System.Drawing.Size(171, 26);
            this.cmbHoraTarea.TabIndex = 9;
            // 
            // pickerTarea
            // 
            this.pickerTarea.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerTarea.Location = new System.Drawing.Point(58, 93);
            this.pickerTarea.Name = "pickerTarea";
            this.pickerTarea.Size = new System.Drawing.Size(155, 24);
            this.pickerTarea.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingresa el titulo de la tarea";
            // 
            // txtTarea
            // 
            this.txtTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarea.Location = new System.Drawing.Point(58, 36);
            this.txtTarea.MaxLength = 40;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(356, 24);
            this.txtTarea.TabIndex = 6;
            // 
            // btnGuardarRecordatorio
            // 
            this.btnGuardarRecordatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnGuardarRecordatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRecordatorio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRecordatorio.Location = new System.Drawing.Point(316, 211);
            this.btnGuardarRecordatorio.Name = "btnGuardarRecordatorio";
            this.btnGuardarRecordatorio.Size = new System.Drawing.Size(116, 37);
            this.btnGuardarRecordatorio.TabIndex = 6;
            this.btnGuardarRecordatorio.Text = "Guardar";
            this.btnGuardarRecordatorio.UseVisualStyleBackColor = false;
            this.btnGuardarRecordatorio.Click += new System.EventHandler(this.btnGuardarRecordatorio_Click);
            // 
            // btnGuardarTarea
            // 
            this.btnGuardarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnGuardarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTarea.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTarea.Location = new System.Drawing.Point(298, 250);
            this.btnGuardarTarea.Name = "btnGuardarTarea";
            this.btnGuardarTarea.Size = new System.Drawing.Size(116, 37);
            this.btnGuardarTarea.TabIndex = 14;
            this.btnGuardarTarea.Text = "Guardar";
            this.btnGuardarTarea.UseVisualStyleBackColor = false;
            this.btnGuardarTarea.Click += new System.EventHandler(this.btnGuardarTarea_Click);
            // 
            // AgregarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "AgregarEventos";
            this.Text = "AgregarEventos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHoraRecordatorio;
        private System.Windows.Forms.DateTimePicker pickerRecordatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecordatorio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionTarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHoraTarea;
        private System.Windows.Forms.DateTimePicker pickerTarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnGuardarRecordatorio;
        private System.Windows.Forms.Button btnGuardarTarea;
    }
}