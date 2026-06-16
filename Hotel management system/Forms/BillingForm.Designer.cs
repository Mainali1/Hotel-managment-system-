using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    partial class BillingForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvBills;
        private TextBox txtBillID;
        private TextBox txtInvoiceNumber;
        private TextBox txtNumberOfNights;
        private TextBox txtRatePerNight;
        private TextBox txtSubTotal;
        private TextBox txtAdditionalCharges;
        private TextBox txtTotalAmount;
        private TextBox txtPaymentStatus;
        private TextBox txtGeneratedAt;
        private TextBox txtPaidAt;
        private TextBox txtInvoicePreview;
        private Button btnMarkPaid;
        private Button btnViewInvoice;
        private Button btnPrint;
        private Button btnRefresh;
        private Label lblTitle;
        private Label lblBillID;
        private Label lblInvoiceNumber;
        private Label lblNumberOfNights;
        private Label lblRatePerNight;
        private Label lblSubTotal;
        private Label lblAdditionalCharges;
        private Label lblTotalAmount;
        private Label lblPaymentStatus;
        private Label lblGeneratedAt;
        private Label lblPaidAt;
        private Label lblInvoicePreview;
        private Panel panelDetails;
        private Panel panelPreview;
        private Panel panelGrid;

        private void InitializeComponent()
        {
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtNumberOfNights = new System.Windows.Forms.TextBox();
            this.txtRatePerNight = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtAdditionalCharges = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.txtGeneratedAt = new System.Windows.Forms.TextBox();
            this.txtPaidAt = new System.Windows.Forms.TextBox();
            this.txtInvoicePreview = new System.Windows.Forms.TextBox();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblRatePerNight = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblAdditionalCharges = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblGeneratedAt = new System.Windows.Forms.Label();
            this.lblPaidAt = new System.Windows.Forms.Label();
            this.lblInvoicePreview = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBills.ColumnHeadersHeight = 29;
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.Location = new System.Drawing.Point(0, 0);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.Size = new System.Drawing.Size(760, 300);
            this.dgvBills.TabIndex = 0;
            // 
            // txtBillID
            // 
            this.txtBillID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBillID.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtBillID.Location = new System.Drawing.Point(10, 30);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(250, 23);
            this.txtBillID.TabIndex = 1;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtInvoiceNumber.Location = new System.Drawing.Point(10, 58);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(250, 23);
            this.txtInvoiceNumber.TabIndex = 3;
            // 
            // txtNumberOfNights
            // 
            this.txtNumberOfNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNumberOfNights.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtNumberOfNights.Location = new System.Drawing.Point(10, 86);
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.ReadOnly = true;
            this.txtNumberOfNights.Size = new System.Drawing.Size(250, 23);
            this.txtNumberOfNights.TabIndex = 5;
            // 
            // txtRatePerNight
            // 
            this.txtRatePerNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRatePerNight.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtRatePerNight.Location = new System.Drawing.Point(10, 114);
            this.txtRatePerNight.Name = "txtRatePerNight";
            this.txtRatePerNight.ReadOnly = true;
            this.txtRatePerNight.Size = new System.Drawing.Size(250, 23);
            this.txtRatePerNight.TabIndex = 7;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSubTotal.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtSubTotal.Location = new System.Drawing.Point(10, 142);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(250, 23);
            this.txtSubTotal.TabIndex = 9;
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtAdditionalCharges.Location = new System.Drawing.Point(10, 170);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.ReadOnly = true;
            this.txtAdditionalCharges.Size = new System.Drawing.Size(250, 23);
            this.txtAdditionalCharges.TabIndex = 11;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(10, 198);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(250, 26);
            this.txtTotalAmount.TabIndex = 13;
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPaymentStatus.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.txtPaymentStatus.Location = new System.Drawing.Point(10, 236);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.ReadOnly = true;
            this.txtPaymentStatus.Size = new System.Drawing.Size(250, 24);
            this.txtPaymentStatus.TabIndex = 15;
            // 
            // txtGeneratedAt
            // 
            this.txtGeneratedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtGeneratedAt.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtGeneratedAt.Location = new System.Drawing.Point(10, 279);
            this.txtGeneratedAt.Name = "txtGeneratedAt";
            this.txtGeneratedAt.ReadOnly = true;
            this.txtGeneratedAt.Size = new System.Drawing.Size(250, 23);
            this.txtGeneratedAt.TabIndex = 17;
            // 
            // txtPaidAt
            // 
            this.txtPaidAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPaidAt.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtPaidAt.Location = new System.Drawing.Point(10, 325);
            this.txtPaidAt.Name = "txtPaidAt";
            this.txtPaidAt.ReadOnly = true;
            this.txtPaidAt.Size = new System.Drawing.Size(250, 23);
            this.txtPaidAt.TabIndex = 19;
            // 
            // txtInvoicePreview
            // 
            this.txtInvoicePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtInvoicePreview.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtInvoicePreview.Location = new System.Drawing.Point(10, 35);
            this.txtInvoicePreview.Multiline = true;
            this.txtInvoicePreview.Name = "txtInvoicePreview";
            this.txtInvoicePreview.ReadOnly = true;
            this.txtInvoicePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoicePreview.Size = new System.Drawing.Size(1040, 265);
            this.txtInvoicePreview.TabIndex = 1;
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnMarkPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkPaid.FlatAppearance.BorderSize = 0;
            this.btnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkPaid.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMarkPaid.Location = new System.Drawing.Point(803, 366);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(130, 40);
            this.btnMarkPaid.TabIndex = 20;
            this.btnMarkPaid.Text = "MARK PAID";
            this.btnMarkPaid.UseVisualStyleBackColor = false;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.btnViewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInvoice.FlatAppearance.BorderSize = 0;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewInvoice.Location = new System.Drawing.Point(950, 366);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(130, 40);
            this.btnViewInvoice.TabIndex = 21;
            this.btnViewInvoice.Text = "VIEW INVOICE";
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrint.Location = new System.Drawing.Point(456, 370);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 40);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(320, 370);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BILLING MANAGEMENT";
            // 
            // lblBillID
            // 
            this.lblBillID.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblBillID.Location = new System.Drawing.Point(10, 15);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(120, 15);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "BILL ID:";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNumber.Location = new System.Drawing.Point(10, 43);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(120, 15);
            this.lblInvoiceNumber.TabIndex = 2;
            this.lblInvoiceNumber.Text = "INVOICE #:";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfNights.Location = new System.Drawing.Point(10, 71);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(120, 15);
            this.lblNumberOfNights.TabIndex = 4;
            this.lblNumberOfNights.Text = "NIGHTS:";
            // 
            // lblRatePerNight
            // 
            this.lblRatePerNight.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblRatePerNight.Location = new System.Drawing.Point(10, 99);
            this.lblRatePerNight.Name = "lblRatePerNight";
            this.lblRatePerNight.Size = new System.Drawing.Size(120, 15);
            this.lblRatePerNight.TabIndex = 6;
            this.lblRatePerNight.Text = "RATE/NIGHT:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.Location = new System.Drawing.Point(10, 127);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(120, 15);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "SUB TOTAL:";
            // 
            // lblAdditionalCharges
            // 
            this.lblAdditionalCharges.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblAdditionalCharges.Location = new System.Drawing.Point(10, 155);
            this.lblAdditionalCharges.Name = "lblAdditionalCharges";
            this.lblAdditionalCharges.Size = new System.Drawing.Size(120, 15);
            this.lblAdditionalCharges.TabIndex = 10;
            this.lblAdditionalCharges.Text = "ADDITIONAL:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 183);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(120, 15);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "TOTAL:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.Location = new System.Drawing.Point(10, 221);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(120, 15);
            this.lblPaymentStatus.TabIndex = 14;
            this.lblPaymentStatus.Text = "STATUS:";
            // 
            // lblGeneratedAt
            // 
            this.lblGeneratedAt.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblGeneratedAt.Location = new System.Drawing.Point(10, 264);
            this.lblGeneratedAt.Name = "lblGeneratedAt";
            this.lblGeneratedAt.Size = new System.Drawing.Size(120, 15);
            this.lblGeneratedAt.TabIndex = 16;
            this.lblGeneratedAt.Text = "GENERATED:";
            // 
            // lblPaidAt
            // 
            this.lblPaidAt.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.lblPaidAt.Location = new System.Drawing.Point(10, 304);
            this.lblPaidAt.Name = "lblPaidAt";
            this.lblPaidAt.Size = new System.Drawing.Size(120, 15);
            this.lblPaidAt.TabIndex = 18;
            this.lblPaidAt.Text = "PAID AT:";
            // 
            // lblInvoicePreview
            // 
            this.lblInvoicePreview.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.lblInvoicePreview.Location = new System.Drawing.Point(10, 10);
            this.lblInvoicePreview.Name = "lblInvoicePreview";
            this.lblInvoicePreview.Size = new System.Drawing.Size(200, 20);
            this.lblInvoicePreview.TabIndex = 0;
            this.lblInvoicePreview.Text = "INVOICE PREVIEW:";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelDetails.Controls.Add(this.lblBillID);
            this.panelDetails.Controls.Add(this.txtBillID);
            this.panelDetails.Controls.Add(this.lblInvoiceNumber);
            this.panelDetails.Controls.Add(this.txtInvoiceNumber);
            this.panelDetails.Controls.Add(this.lblNumberOfNights);
            this.panelDetails.Controls.Add(this.txtNumberOfNights);
            this.panelDetails.Controls.Add(this.lblRatePerNight);
            this.panelDetails.Controls.Add(this.txtRatePerNight);
            this.panelDetails.Controls.Add(this.lblSubTotal);
            this.panelDetails.Controls.Add(this.txtSubTotal);
            this.panelDetails.Controls.Add(this.lblAdditionalCharges);
            this.panelDetails.Controls.Add(this.txtAdditionalCharges);
            this.panelDetails.Controls.Add(this.lblTotalAmount);
            this.panelDetails.Controls.Add(this.txtTotalAmount);
            this.panelDetails.Controls.Add(this.lblPaymentStatus);
            this.panelDetails.Controls.Add(this.txtPaymentStatus);
            this.panelDetails.Controls.Add(this.lblGeneratedAt);
            this.panelDetails.Controls.Add(this.txtGeneratedAt);
            this.panelDetails.Controls.Add(this.lblPaidAt);
            this.panelDetails.Controls.Add(this.txtPaidAt);
            this.panelDetails.Location = new System.Drawing.Point(20, 60);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(294, 368);
            this.panelDetails.TabIndex = 1;
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelPreview.Controls.Add(this.lblInvoicePreview);
            this.panelPreview.Controls.Add(this.txtInvoicePreview);
            this.panelPreview.Location = new System.Drawing.Point(20, 434);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(1060, 246);
            this.panelPreview.TabIndex = 3;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelGrid.Controls.Add(this.dgvBills);
            this.panelGrid.Location = new System.Drawing.Point(320, 60);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(760, 300);
            this.panelGrid.TabIndex = 2;
            // 
            // BillingForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.btnViewInvoice);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Name = "BillingForm";
            this.Text = "Billing Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}