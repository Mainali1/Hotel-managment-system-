using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    partial class BillingForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvBills;
        private Guna2TextBox txtBillID;
        private Guna2TextBox txtInvoiceNumber;
        private Guna2TextBox txtNumberOfNights;
        private Guna2TextBox txtRatePerNight;
        private Guna2TextBox txtSubTotal;
        private Guna2TextBox txtAdditionalCharges;
        private Guna2TextBox txtTotalAmount;
        private Guna2TextBox txtPaymentStatus;
        private Guna2TextBox txtGeneratedAt;
        private Guna2TextBox txtPaidAt;
        private Guna2TextBox txtInvoicePreview;
        private Guna2Button btnMarkPaid;
        private Guna2Button btnViewInvoice;
        private Guna2Button btnPrint;
        private Guna2Button btnRefresh;
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
        private Guna2Panel panelDetails;
        private Guna2Panel panelPreview;
        private Guna2Panel panelGrid;
        private Guna2Panel panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBills = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBillID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInvoiceNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumberOfNights = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRatePerNight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdditionalCharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPaymentStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGeneratedAt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPaidAt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInvoicePreview = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMarkPaid = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
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
            this.panelDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBills.ColumnHeadersHeight = 15;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBills.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvBills.Location = new System.Drawing.Point(0, 0);
            this.dgvBills.MultiSelect = false;
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.Size = new System.Drawing.Size(860, 220);
            this.dgvBills.TabIndex = 0;
            this.dgvBills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvBills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBills.ThemeStyle.ReadOnly = true;
            this.dgvBills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBillID
            // 
            this.txtBillID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtBillID.BorderRadius = 6;
            this.txtBillID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBillID.DefaultText = "";
            this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillID.Location = new System.Drawing.Point(10, 32);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.PlaceholderText = "";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.SelectedText = "";
            this.txtBillID.Size = new System.Drawing.Size(250, 28);
            this.txtBillID.TabIndex = 1;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtInvoiceNumber.BorderRadius = 6;
            this.txtInvoiceNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInvoiceNumber.DefaultText = "";
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInvoiceNumber.Location = new System.Drawing.Point(10, 82);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PlaceholderText = "";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(250, 28);
            this.txtInvoiceNumber.TabIndex = 3;
            // 
            // txtNumberOfNights
            // 
            this.txtNumberOfNights.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtNumberOfNights.BorderRadius = 6;
            this.txtNumberOfNights.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNumberOfNights.DefaultText = "";
            this.txtNumberOfNights.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberOfNights.Location = new System.Drawing.Point(10, 132);
            this.txtNumberOfNights.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.PlaceholderText = "";
            this.txtNumberOfNights.ReadOnly = true;
            this.txtNumberOfNights.SelectedText = "";
            this.txtNumberOfNights.Size = new System.Drawing.Size(250, 28);
            this.txtNumberOfNights.TabIndex = 5;
            // 
            // txtRatePerNight
            // 
            this.txtRatePerNight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtRatePerNight.BorderRadius = 6;
            this.txtRatePerNight.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRatePerNight.DefaultText = "";
            this.txtRatePerNight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRatePerNight.Location = new System.Drawing.Point(10, 182);
            this.txtRatePerNight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRatePerNight.Name = "txtRatePerNight";
            this.txtRatePerNight.PlaceholderText = "";
            this.txtRatePerNight.ReadOnly = true;
            this.txtRatePerNight.SelectedText = "";
            this.txtRatePerNight.Size = new System.Drawing.Size(250, 28);
            this.txtRatePerNight.TabIndex = 7;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtSubTotal.BorderRadius = 6;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubTotal.DefaultText = "";
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubTotal.Location = new System.Drawing.Point(10, 232);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PlaceholderText = "";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.Size = new System.Drawing.Size(250, 28);
            this.txtSubTotal.TabIndex = 9;
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtAdditionalCharges.BorderRadius = 6;
            this.txtAdditionalCharges.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAdditionalCharges.DefaultText = "";
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdditionalCharges.Location = new System.Drawing.Point(10, 282);
            this.txtAdditionalCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.PlaceholderText = "";
            this.txtAdditionalCharges.ReadOnly = true;
            this.txtAdditionalCharges.SelectedText = "";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(250, 28);
            this.txtAdditionalCharges.TabIndex = 11;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtTotalAmount.BorderRadius = 6;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalAmount.DefaultText = "";
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(10, 332);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(250, 32);
            this.txtTotalAmount.TabIndex = 13;
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtPaymentStatus.BorderRadius = 6;
            this.txtPaymentStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPaymentStatus.DefaultText = "";
            this.txtPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaymentStatus.Location = new System.Drawing.Point(10, 387);
            this.txtPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.PlaceholderText = "";
            this.txtPaymentStatus.ReadOnly = true;
            this.txtPaymentStatus.SelectedText = "";
            this.txtPaymentStatus.Size = new System.Drawing.Size(250, 28);
            this.txtPaymentStatus.TabIndex = 15;
            // 
            // txtGeneratedAt
            // 
            this.txtGeneratedAt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtGeneratedAt.BorderRadius = 6;
            this.txtGeneratedAt.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGeneratedAt.DefaultText = "";
            this.txtGeneratedAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGeneratedAt.Location = new System.Drawing.Point(10, 437);
            this.txtGeneratedAt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeneratedAt.Name = "txtGeneratedAt";
            this.txtGeneratedAt.PlaceholderText = "";
            this.txtGeneratedAt.ReadOnly = true;
            this.txtGeneratedAt.SelectedText = "";
            this.txtGeneratedAt.Size = new System.Drawing.Size(250, 28);
            this.txtGeneratedAt.TabIndex = 17;
            // 
            // txtPaidAt
            // 
            this.txtPaidAt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtPaidAt.BorderRadius = 6;
            this.txtPaidAt.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPaidAt.DefaultText = "";
            this.txtPaidAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaidAt.Location = new System.Drawing.Point(10, 487);
            this.txtPaidAt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaidAt.Name = "txtPaidAt";
            this.txtPaidAt.PlaceholderText = "";
            this.txtPaidAt.ReadOnly = true;
            this.txtPaidAt.SelectedText = "";
            this.txtPaidAt.Size = new System.Drawing.Size(250, 28);
            this.txtPaidAt.TabIndex = 19;
            // 
            // txtInvoicePreview
            // 
            this.txtInvoicePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtInvoicePreview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtInvoicePreview.BorderRadius = 8;
            this.txtInvoicePreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInvoicePreview.DefaultText = "";
            this.txtInvoicePreview.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtInvoicePreview.Location = new System.Drawing.Point(10, 35);
            this.txtInvoicePreview.Multiline = true;
            this.txtInvoicePreview.Name = "txtInvoicePreview";
            this.txtInvoicePreview.PlaceholderText = "";
            this.txtInvoicePreview.ReadOnly = true;
            this.txtInvoicePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoicePreview.SelectedText = "";
            this.txtInvoicePreview.Size = new System.Drawing.Size(550, 215);
            this.txtInvoicePreview.TabIndex = 1;
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.btnMarkPaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.btnMarkPaid.BorderRadius = 8;
            this.btnMarkPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.btnMarkPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkPaid.ForeColor = System.Drawing.Color.White;
            this.btnMarkPaid.Location = new System.Drawing.Point(10, 15);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(130, 40);
            this.btnMarkPaid.TabIndex = 0;
            this.btnMarkPaid.Text = "MARK PAID";
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(254)))));
            this.btnViewInvoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(254)))));
            this.btnViewInvoice.BorderRadius = 8;
            this.btnViewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(254)))));
            this.btnViewInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnViewInvoice.Location = new System.Drawing.Point(146, 15);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(130, 40);
            this.btnViewInvoice.TabIndex = 1;
            this.btnViewInvoice.Text = "VIEW INVOICE";
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPrint.BorderRadius = 8;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(290, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnRefresh.Location = new System.Drawing.Point(430, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BILLING MANAGEMENT";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblBillID.Location = new System.Drawing.Point(10, 15);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(58, 19);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "BILL ID:";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(10, 65);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(80, 19);
            this.lblInvoiceNumber.TabIndex = 2;
            this.lblInvoiceNumber.Text = "INVOICE #:";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfNights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblNumberOfNights.Location = new System.Drawing.Point(10, 115);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(65, 19);
            this.lblNumberOfNights.TabIndex = 4;
            this.lblNumberOfNights.Text = "NIGHTS:";
            // 
            // lblRatePerNight
            // 
            this.lblRatePerNight.AutoSize = true;
            this.lblRatePerNight.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRatePerNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblRatePerNight.Location = new System.Drawing.Point(10, 165);
            this.lblRatePerNight.Name = "lblRatePerNight";
            this.lblRatePerNight.Size = new System.Drawing.Size(96, 19);
            this.lblRatePerNight.TabIndex = 6;
            this.lblRatePerNight.Text = "RATE/NIGHT:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblSubTotal.Location = new System.Drawing.Point(10, 215);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(85, 19);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "SUB TOTAL:";
            // 
            // lblAdditionalCharges
            // 
            this.lblAdditionalCharges.AutoSize = true;
            this.lblAdditionalCharges.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAdditionalCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblAdditionalCharges.Location = new System.Drawing.Point(10, 265);
            this.lblAdditionalCharges.Name = "lblAdditionalCharges";
            this.lblAdditionalCharges.Size = new System.Drawing.Size(98, 19);
            this.lblAdditionalCharges.TabIndex = 10;
            this.lblAdditionalCharges.Text = "ADDITIONAL:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 315);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(54, 19);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "TOTAL:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblPaymentStatus.Location = new System.Drawing.Point(10, 370);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(63, 19);
            this.lblPaymentStatus.TabIndex = 14;
            this.lblPaymentStatus.Text = "STATUS:";
            // 
            // lblGeneratedAt
            // 
            this.lblGeneratedAt.AutoSize = true;
            this.lblGeneratedAt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblGeneratedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblGeneratedAt.Location = new System.Drawing.Point(10, 420);
            this.lblGeneratedAt.Name = "lblGeneratedAt";
            this.lblGeneratedAt.Size = new System.Drawing.Size(91, 19);
            this.lblGeneratedAt.TabIndex = 16;
            this.lblGeneratedAt.Text = "GENERATED:";
            // 
            // lblPaidAt
            // 
            this.lblPaidAt.AutoSize = true;
            this.lblPaidAt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPaidAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblPaidAt.Location = new System.Drawing.Point(10, 470);
            this.lblPaidAt.Name = "lblPaidAt";
            this.lblPaidAt.Size = new System.Drawing.Size(66, 19);
            this.lblPaidAt.TabIndex = 18;
            this.lblPaidAt.Text = "PAID AT:";
            // 
            // lblInvoicePreview
            // 
            this.lblInvoicePreview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInvoicePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblInvoicePreview.Location = new System.Drawing.Point(10, 10);
            this.lblInvoicePreview.Name = "lblInvoicePreview";
            this.lblInvoicePreview.Size = new System.Drawing.Size(200, 20);
            this.lblInvoicePreview.TabIndex = 0;
            this.lblInvoicePreview.Text = "INVOICE PREVIEW:";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelDetails.BorderRadius = 10;
            this.panelDetails.BorderThickness = 1;
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
            this.panelDetails.Location = new System.Drawing.Point(20, 290);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(280, 340);
            this.panelDetails.TabIndex = 2;
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.White;
            this.panelPreview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelPreview.BorderRadius = 10;
            this.panelPreview.BorderThickness = 1;
            this.panelPreview.Controls.Add(this.lblInvoicePreview);
            this.panelPreview.Controls.Add(this.txtInvoicePreview);
            this.panelPreview.Location = new System.Drawing.Point(310, 290);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(570, 260);
            this.panelPreview.TabIndex = 3;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelGrid.BorderRadius = 10;
            this.panelGrid.BorderThickness = 1;
            this.panelGrid.Controls.Add(this.dgvBills);
            this.panelGrid.Location = new System.Drawing.Point(20, 60);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(860, 220);
            this.panelGrid.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnMarkPaid);
            this.panelButtons.Controls.Add(this.btnViewInvoice);
            this.panelButtons.Controls.Add(this.btnPrint);
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Location = new System.Drawing.Point(310, 560);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(570, 70);
            this.panelButtons.TabIndex = 4;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(935, 666);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.panelButtons);
            this.Name = "BillingForm";
            this.Text = "Billing Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}