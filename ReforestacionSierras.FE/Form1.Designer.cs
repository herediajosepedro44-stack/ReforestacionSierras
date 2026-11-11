namespace ReforestacionSierras.FE
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEspecie = new TextBox();
            txtZona = new TextBox();
            txtFecha = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            BtAceptar = new Button();
            BtBuscar = new Button();
            dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(343, 41);
            label1.TabIndex = 0;
            label1.Text = "ARBOLES PLANTADOS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(232, 164);
            label2.TabIndex = 2;
            label2.Text = "ESPECIE:\r\nChañar-Espinillo\r\nQuebracho-Tala\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 93);
            label3.Name = "label3";
            label3.Size = new Size(162, 123);
            label3.TabIndex = 4;
            label3.Text = "ZONA:\r\nNorte-Sur\r\nEste-Oeste";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(794, 80);
            label4.Name = "label4";
            label4.Size = new Size(343, 123);
            label4.TabIndex = 6;
            label4.Text = "FECHA DE PLANTACION:\r\ndia/mes/año\r\n05/09/2026\r\n";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(13, 235);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(250, 47);
            txtEspecie.TabIndex = 7;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(392, 235);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(250, 47);
            txtZona.TabIndex = 8;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(794, 235);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(250, 47);
            txtFecha.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Location = new Point(1286, 392);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 47);
            txtId.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1299, 315);
            label5.Name = "label5";
            label5.Size = new Size(51, 41);
            label5.TabIndex = 11;
            label5.Text = "Id:";
            // 
            // BtAceptar
            // 
            BtAceptar.AutoSize = true;
            BtAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtAceptar.Location = new Point(1203, 214);
            BtAceptar.Name = "BtAceptar";
            BtAceptar.Size = new Size(333, 58);
            BtAceptar.TabIndex = 12;
            BtAceptar.Text = "ACEPTAR/PLANTADO";
            BtAceptar.UseVisualStyleBackColor = true;
            BtAceptar.Click += BtAceptar_Click_1;
            // 
            // BtBuscar
            // 
            BtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtBuscar.Location = new Point(1289, 510);
            BtBuscar.Name = "BtBuscar";
            BtBuscar.Size = new Size(188, 58);
            BtBuscar.TabIndex = 13;
            BtBuscar.Text = "BUSCAR";
            BtBuscar.UseVisualStyleBackColor = true;
            BtBuscar.Click += BtBuscar_Click_1;
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(12, 301);
            dg.Name = "dg";
            dg.RowHeadersWidth = 102;
            dg.Size = new Size(1242, 452);
            dg.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 792);
            Controls.Add(dg);
            Controls.Add(BtBuscar);
            Controls.Add(BtAceptar);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(txtFecha);
            Controls.Add(txtZona);
            Controls.Add(txtEspecie);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEspecie;
        private TextBox txtZona;
        private TextBox txtFecha;
        private TextBox txtId;
        private Label label5;
        private Button BtAceptar;
        private Button BtBuscar;
        private DataGridView dg;
    }
}
