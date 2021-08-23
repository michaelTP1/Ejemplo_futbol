
namespace Ejemplo_futbol
{
    partial class Main_view
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
            this.liga_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_futbolistas_activos = new System.Windows.Forms.Label();
            this.label_condiciones = new System.Windows.Forms.Label();
            this.box_equipo = new System.Windows.Forms.TextBox();
            this.box_precio_anual = new System.Windows.Forms.TextBox();
            this.box_precio_recision = new System.Windows.Forms.TextBox();
            this.button_consulta_contratos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // liga_box
            // 
            this.liga_box.FormattingEnabled = true;
            this.liga_box.Location = new System.Drawing.Point(82, 47);
            this.liga_box.Name = "liga_box";
            this.liga_box.Size = new System.Drawing.Size(121, 21);
            this.liga_box.TabIndex = 0;
            this.liga_box.SelectedIndexChanged += new System.EventHandler(this.event_liga_index_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liga:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 347);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "precio anual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "precio recisión:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "futbolistas activos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "futbolistas condiciones:";
            // 
            // label_futbolistas_activos
            // 
            this.label_futbolistas_activos.AutoSize = true;
            this.label_futbolistas_activos.Location = new System.Drawing.Point(203, 253);
            this.label_futbolistas_activos.Name = "label_futbolistas_activos";
            this.label_futbolistas_activos.Size = new System.Drawing.Size(0, 13);
            this.label_futbolistas_activos.TabIndex = 8;
            // 
            // label_condiciones
            // 
            this.label_condiciones.AutoSize = true;
            this.label_condiciones.Location = new System.Drawing.Point(203, 312);
            this.label_condiciones.Name = "label_condiciones";
            this.label_condiciones.Size = new System.Drawing.Size(0, 13);
            this.label_condiciones.TabIndex = 9;
            // 
            // box_equipo
            // 
            this.box_equipo.Location = new System.Drawing.Point(103, 100);
            this.box_equipo.Name = "box_equipo";
            this.box_equipo.Size = new System.Drawing.Size(100, 20);
            this.box_equipo.TabIndex = 10;
            // 
            // box_precio_anual
            // 
            this.box_precio_anual.Location = new System.Drawing.Point(103, 149);
            this.box_precio_anual.Name = "box_precio_anual";
            this.box_precio_anual.Size = new System.Drawing.Size(100, 20);
            this.box_precio_anual.TabIndex = 11;
            // 
            // box_precio_recision
            // 
            this.box_precio_recision.Location = new System.Drawing.Point(103, 188);
            this.box_precio_recision.Name = "box_precio_recision";
            this.box_precio_recision.Size = new System.Drawing.Size(100, 20);
            this.box_precio_recision.TabIndex = 12;
            // 
            // button_consulta_contratos
            // 
            this.button_consulta_contratos.Location = new System.Drawing.Point(128, 371);
            this.button_consulta_contratos.Name = "button_consulta_contratos";
            this.button_consulta_contratos.Size = new System.Drawing.Size(75, 23);
            this.button_consulta_contratos.TabIndex = 13;
            this.button_consulta_contratos.Text = "comprobar";
            this.button_consulta_contratos.UseVisualStyleBackColor = true;
            this.button_consulta_contratos.Click += new System.EventHandler(this.button_consulta_contratos_Click);
            // 
            // Main_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_consulta_contratos);
            this.Controls.Add(this.box_precio_recision);
            this.Controls.Add(this.box_precio_anual);
            this.Controls.Add(this.box_equipo);
            this.Controls.Add(this.label_condiciones);
            this.Controls.Add(this.label_futbolistas_activos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liga_box);
            this.Name = "Main_view";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox liga_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_futbolistas_activos;
        private System.Windows.Forms.Label label_condiciones;
        private System.Windows.Forms.TextBox box_equipo;
        private System.Windows.Forms.TextBox box_precio_anual;
        private System.Windows.Forms.TextBox box_precio_recision;
        private System.Windows.Forms.Button button_consulta_contratos;
    }
}

