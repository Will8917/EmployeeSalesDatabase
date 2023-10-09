namespace EmployeeSalesDatabase
{
    partial class Form1
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.labelCount = new System.Windows.Forms.Label();
            this.txtXMLData = new System.Windows.Forms.TextBox();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnCountEmployees = new System.Windows.Forms.Button();
            this.btnShowXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 44);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(284, 138);
            this.dgvEmployees.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 185);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(91, 13);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Total Employees: ";
            // 
            // txtXMLData
            // 
            this.txtXMLData.Location = new System.Drawing.Point(12, 201);
            this.txtXMLData.Multiline = true;
            this.txtXMLData.Name = "txtXMLData";
            this.txtXMLData.Size = new System.Drawing.Size(284, 61);
            this.txtXMLData.TabIndex = 2;
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(12, 15);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(100, 23);
            this.btnShowEmployees.TabIndex = 3;
            this.btnShowEmployees.Text = "Show Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnCountEmployees
            // 
            this.btnCountEmployees.Location = new System.Drawing.Point(118, 15);
            this.btnCountEmployees.Name = "btnCountEmployees";
            this.btnCountEmployees.Size = new System.Drawing.Size(97, 23);
            this.btnCountEmployees.TabIndex = 4;
            this.btnCountEmployees.Text = "Count Employees";
            this.btnCountEmployees.UseVisualStyleBackColor = true;
            this.btnCountEmployees.Click += new System.EventHandler(this.btnCountEmployees_Click);
            // 
            // btnShowXML
            // 
            this.btnShowXML.Location = new System.Drawing.Point(221, 15);
            this.btnShowXML.Name = "btnShowXML";
            this.btnShowXML.Size = new System.Drawing.Size(75, 23);
            this.btnShowXML.TabIndex = 5;
            this.btnShowXML.Text = "Show XML";
            this.btnShowXML.UseVisualStyleBackColor = true;
            this.btnShowXML.Click += new System.EventHandler(this.btnShowXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 276);
            this.Controls.Add(this.btnShowXML);
            this.Controls.Add(this.btnCountEmployees);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.txtXMLData);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Form1";
            this.Text = "Lab 3(w6)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox txtXMLData;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Button btnCountEmployees;
        private System.Windows.Forms.Button btnShowXML;
    }
}

