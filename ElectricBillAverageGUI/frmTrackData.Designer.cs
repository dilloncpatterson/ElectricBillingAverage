
namespace ElectricBillAverageGUI
{
    partial class frmTrackData
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
            this.lstCustData = new System.Windows.Forms.ListBox();
            this.lblAmountCust = new System.Windows.Forms.Label();
            this.lblKWhUsed = new System.Windows.Forms.Label();
            this.lblAverageBill = new System.Windows.Forms.Label();
            this.txtAmountOfCust = new System.Windows.Forms.TextBox();
            this.txtKWhTotal = new System.Windows.Forms.TextBox();
            this.txtAverageBill = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustData
            // 
            this.lstCustData.FormattingEnabled = true;
            this.lstCustData.ItemHeight = 21;
            this.lstCustData.Location = new System.Drawing.Point(54, 28);
            this.lstCustData.Margin = new System.Windows.Forms.Padding(4);
            this.lstCustData.Name = "lstCustData";
            this.lstCustData.Size = new System.Drawing.Size(559, 172);
            this.lstCustData.TabIndex = 0;
            // 
            // lblAmountCust
            // 
            this.lblAmountCust.AutoSize = true;
            this.lblAmountCust.Location = new System.Drawing.Point(270, 234);
            this.lblAmountCust.Name = "lblAmountCust";
            this.lblAmountCust.Size = new System.Drawing.Size(166, 21);
            this.lblAmountCust.TabIndex = 1;
            this.lblAmountCust.Text = "Amount of Customers:";
            // 
            // lblKWhUsed
            // 
            this.lblKWhUsed.AutoSize = true;
            this.lblKWhUsed.Location = new System.Drawing.Point(270, 283);
            this.lblKWhUsed.Name = "lblKWhUsed";
            this.lblKWhUsed.Size = new System.Drawing.Size(121, 21);
            this.lblKWhUsed.TabIndex = 2;
            this.lblKWhUsed.Text = "Total KWh Used:";
            // 
            // lblAverageBill
            // 
            this.lblAverageBill.AutoSize = true;
            this.lblAverageBill.Location = new System.Drawing.Point(270, 332);
            this.lblAverageBill.Name = "lblAverageBill";
            this.lblAverageBill.Size = new System.Drawing.Size(155, 21);
            this.lblAverageBill.TabIndex = 3;
            this.lblAverageBill.Text = "Average Bill Amount:";
            // 
            // txtAmountOfCust
            // 
            this.txtAmountOfCust.Location = new System.Drawing.Point(490, 231);
            this.txtAmountOfCust.Name = "txtAmountOfCust";
            this.txtAmountOfCust.Size = new System.Drawing.Size(165, 29);
            this.txtAmountOfCust.TabIndex = 4;
            // 
            // txtKWhTotal
            // 
            this.txtKWhTotal.Location = new System.Drawing.Point(490, 280);
            this.txtKWhTotal.Name = "txtKWhTotal";
            this.txtKWhTotal.Size = new System.Drawing.Size(165, 29);
            this.txtKWhTotal.TabIndex = 5;
            // 
            // txtAverageBill
            // 
            this.txtAverageBill.Location = new System.Drawing.Point(490, 324);
            this.txtAverageBill.Name = "txtAverageBill";
            this.txtAverageBill.Size = new System.Drawing.Size(165, 29);
            this.txtAverageBill.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(66, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTrackData
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(680, 407);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAverageBill);
            this.Controls.Add(this.txtKWhTotal);
            this.Controls.Add(this.txtAmountOfCust);
            this.Controls.Add(this.lblAverageBill);
            this.Controls.Add(this.lblKWhUsed);
            this.Controls.Add(this.lblAmountCust);
            this.Controls.Add(this.lstCustData);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrackData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Data";
            this.Load += new System.EventHandler(this.frmTrackData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustData;
        private System.Windows.Forms.Label lblAmountCust;
        private System.Windows.Forms.Label lblKWhUsed;
        private System.Windows.Forms.Label lblAverageBill;
        private System.Windows.Forms.TextBox txtAmountOfCust;
        private System.Windows.Forms.TextBox txtKWhTotal;
        private System.Windows.Forms.TextBox txtAverageBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}

