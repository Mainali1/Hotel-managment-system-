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
            this.dgvBills = new DataGridView();
            this.txtBillID = new TextBox();
            this.txtInvoiceNumber = new TextBox();
            this.txtNumberOfNights = new TextBox();
            this.txtRatePerNight = new TextBox();
            this.txtSubTotal = new TextBox();
            this.txtAdditionalCharges = new TextBox();
            this.txtTotalAmount = new TextBox();
            this.txtPaymentStatus = new TextBox();
            this.txtGeneratedAt = new TextBox();
            this.txtPaidAt = new TextBox();
            this.txtInvoicePreview = new TextBox();
            this.btnMarkPaid = new Button();
            this.btnViewInvoice = new Button();
            this.btnPrint = new Button();
            this.btnRefresh = new Button();
            this.lblTitle = new Label();
            this.lblBillID = new Label();
            this.lblInvoiceNumber = new Label();
            this.lblNumberOfNights = new Label();
            this.lblRatePerNight = new Label();
            this.lblSubTotal = new Label();
            this.lblAdditionalCharges = new Label();
            this.lblTotalAmount = new Label();
            this.lblPaymentStatus = new Label();
            this.lblGeneratedAt = new Label();
            this.lblPaidAt = new Label();
            this.lblInvoicePreview = new Label();
            this.panelDetails = new Panel();
            this.panelPreview = new Panel();
            this.panelGrid = new Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();

            //
            // lblTitle
            //
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "BILLING MANAGEMENT";
            this.lblTitle.Font = new Font("Courier New", 16, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(350, 30);

            //
            // panelDetails
            //
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.BackColor = Color.FromArgb(255, 255, 255);
            this.panelDetails.Location = new Point(20, 60);
            this.panelDetails.Size = new Size(280, 300);

            //
            // panelPreview
            //
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.BackColor = Color.FromArgb(255, 255, 255);
            this.panelPreview.Location = new Point(20, 370);
            this.panelPreview.Size = new Size(1060, 310);

            //
            // panelGrid
            //
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.BackColor = Color.FromArgb(255, 255, 255);
            this.panelGrid.Location = new Point(320, 60);
            this.panelGrid.Size = new Size(760, 300);

            //
            // lblBillID
            //
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Text = "BILL ID:";
            this.lblBillID.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblBillID.Location = new Point(10, 15);
            this.lblBillID.Size = new Size(120, 15);

            //
            // txtBillID
            //
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Location = new Point(10, 30);
            this.txtBillID.Size = new Size(250, 25);
            this.txtBillID.Font = new Font("Courier New", 10);
            this.txtBillID.ReadOnly = true;
            this.txtBillID.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblInvoiceNumber
            //
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Text = "INVOICE #:";
            this.lblInvoiceNumber.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblInvoiceNumber.Location = new Point(10, 43);
            this.lblInvoiceNumber.Size = new Size(120, 15);

            //
            // txtInvoiceNumber
            //
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Location = new Point(10, 58);
            this.txtInvoiceNumber.Size = new Size(250, 25);
            this.txtInvoiceNumber.Font = new Font("Courier New", 10);
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblNumberOfNights
            //
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Text = "NIGHTS:";
            this.lblNumberOfNights.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblNumberOfNights.Location = new Point(10, 71);
            this.lblNumberOfNights.Size = new Size(120, 15);

            //
            // txtNumberOfNights
            //
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.Location = new Point(10, 86);
            this.txtNumberOfNights.Size = new Size(250, 25);
            this.txtNumberOfNights.Font = new Font("Courier New", 10);
            this.txtNumberOfNights.ReadOnly = true;
            this.txtNumberOfNights.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblRatePerNight
            //
            this.lblRatePerNight.Name = "lblRatePerNight";
            this.lblRatePerNight.Text = "RATE/NIGHT:";
            this.lblRatePerNight.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblRatePerNight.Location = new Point(10, 99);
            this.lblRatePerNight.Size = new Size(120, 15);

            //
            // txtRatePerNight
            //
            this.txtRatePerNight.Name = "txtRatePerNight";
            this.txtRatePerNight.Location = new Point(10, 114);
            this.txtRatePerNight.Size = new Size(250, 25);
            this.txtRatePerNight.Font = new Font("Courier New", 10);
            this.txtRatePerNight.ReadOnly = true;
            this.txtRatePerNight.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblSubTotal
            //
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Text = "SUB TOTAL:";
            this.lblSubTotal.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblSubTotal.Location = new Point(10, 127);
            this.lblSubTotal.Size = new Size(120, 15);

            //
            // txtSubTotal
            //
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Location = new Point(10, 142);
            this.txtSubTotal.Size = new Size(250, 25);
            this.txtSubTotal.Font = new Font("Courier New", 10);
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblAdditionalCharges
            //
            this.lblAdditionalCharges.Name = "lblAdditionalCharges";
            this.lblAdditionalCharges.Text = "ADDITIONAL:";
            this.lblAdditionalCharges.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblAdditionalCharges.Location = new Point(10, 155);
            this.lblAdditionalCharges.Size = new Size(120, 15);

            //
            // txtAdditionalCharges
            //
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.Location = new Point(10, 170);
            this.txtAdditionalCharges.Size = new Size(250, 25);
            this.txtAdditionalCharges.Font = new Font("Courier New", 10);
            this.txtAdditionalCharges.ReadOnly = true;
            this.txtAdditionalCharges.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblTotalAmount
            //
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Text = "TOTAL:";
            this.lblTotalAmount.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.lblTotalAmount.Location = new Point(10, 183);
            this.lblTotalAmount.Size = new Size(120, 15);

            //
            // txtTotalAmount
            //
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Location = new Point(10, 198);
            this.txtTotalAmount.Size = new Size(250, 25);
            this.txtTotalAmount.Font = new Font("Courier New", 12, FontStyle.Bold);
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblPaymentStatus
            //
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Text = "STATUS:";
            this.lblPaymentStatus.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblPaymentStatus.Location = new Point(10, 221);
            this.lblPaymentStatus.Size = new Size(120, 15);

            //
            // txtPaymentStatus
            //
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Location = new Point(10, 236);
            this.txtPaymentStatus.Size = new Size(250, 25);
            this.txtPaymentStatus.Font = new Font("Courier New", 11, FontStyle.Bold);
            this.txtPaymentStatus.ReadOnly = true;
            this.txtPaymentStatus.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblGeneratedAt
            //
            this.lblGeneratedAt.Name = "lblGeneratedAt";
            this.lblGeneratedAt.Text = "GENERATED:";
            this.lblGeneratedAt.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblGeneratedAt.Location = new Point(10, 264);
            this.lblGeneratedAt.Size = new Size(120, 15);

            //
            // txtGeneratedAt
            //
            this.txtGeneratedAt.Name = "txtGeneratedAt";
            this.txtGeneratedAt.Location = new Point(10, 279);
            this.txtGeneratedAt.Size = new Size(250, 25);
            this.txtGeneratedAt.Font = new Font("Courier New", 10);
            this.txtGeneratedAt.ReadOnly = true;
            this.txtGeneratedAt.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblPaidAt
            //
            this.lblPaidAt.Name = "lblPaidAt";
            this.lblPaidAt.Text = "PAID AT:";
            this.lblPaidAt.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblPaidAt.Location = new Point(10, 307);
            this.lblPaidAt.Size = new Size(120, 15);

            //
            // txtPaidAt
            //
            this.txtPaidAt.Name = "txtPaidAt";
            this.txtPaidAt.Location = new Point(10, 322);
            this.txtPaidAt.Size = new Size(250, 25);
            this.txtPaidAt.Font = new Font("Courier New", 10);
            this.txtPaidAt.ReadOnly = true;
            this.txtPaidAt.BackColor = Color.FromArgb(230, 230, 230);

            //
            // btnMarkPaid
            //
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Text = "MARK PAID";
            this.btnMarkPaid.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnMarkPaid.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnMarkPaid.BackColor = Color.FromArgb(50, 150, 50);
            this.btnMarkPaid.FlatStyle = FlatStyle.Flat;
            this.btnMarkPaid.FlatAppearance.BorderSize = 0;
            this.btnMarkPaid.Location = new Point(10, 265);
            this.btnMarkPaid.Size = new Size(130, 40);
            this.btnMarkPaid.Cursor = Cursors.Hand;
            this.btnMarkPaid.Click += new EventHandler(this.btnMarkPaid_Click);

            //
            // btnViewInvoice
            //
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Text = "VIEW INVOICE";
            this.btnViewInvoice.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnViewInvoice.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnViewInvoice.BackColor = Color.FromArgb(50, 50, 150);
            this.btnViewInvoice.FlatStyle = FlatStyle.Flat;
            this.btnViewInvoice.FlatAppearance.BorderSize = 0;
            this.btnViewInvoice.Location = new Point(145, 265);
            this.btnViewInvoice.Size = new Size(130, 40);
            this.btnViewInvoice.Cursor = Cursors.Hand;
            this.btnViewInvoice.Click += new EventHandler(this.btnViewInvoice_Click);

            //
            // btnPrint
            //
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnPrint.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnPrint.BackColor = Color.FromArgb(0, 0, 0);
            this.btnPrint.FlatStyle = FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Location = new Point(10, 310);
            this.btnPrint.Size = new Size(130, 40);
            this.btnPrint.Cursor = Cursors.Hand;
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);

            //
            // btnRefresh
            //
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.FromArgb(0, 0, 0);
            this.btnRefresh.BackColor = Color.FromArgb(255, 255, 255);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 1;
            this.btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            this.btnRefresh.Location = new Point(145, 310);
            this.btnRefresh.Size = new Size(130, 40);
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            //
            // lblInvoicePreview
            //
            this.lblInvoicePreview.Name = "lblInvoicePreview";
            this.lblInvoicePreview.Text = "INVOICE PREVIEW:";
            this.lblInvoicePreview.Font = new Font("Courier New", 10, FontStyle.Bold);
            this.lblInvoicePreview.Location = new Point(10, 10);
            this.lblInvoicePreview.Size = new Size(200, 20);

            //
            // txtInvoicePreview
            //
            this.txtInvoicePreview.Name = "txtInvoicePreview";
            this.txtInvoicePreview.Location = new Point(10, 35);
            this.txtInvoicePreview.Size = new Size(1040, 265);
            this.txtInvoicePreview.Font = new Font("Courier New", 9);
            this.txtInvoicePreview.Multiline = true;
            this.txtInvoicePreview.ScrollBars = ScrollBars.Vertical;
            this.txtInvoicePreview.ReadOnly = true;
            this.txtInvoicePreview.BackColor = Color.FromArgb(250, 250, 250);

            //
            // dgvBills
            //
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Dock = DockStyle.Fill;
            this.dgvBills.Location = new Point(0, 0);
            this.dgvBills.Size = new Size(760, 300);
            this.dgvBills.BorderStyle = BorderStyle.None;

            //
            // panelDetails contents
            //
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
            this.panelDetails.Controls.Add(this.btnMarkPaid);
            this.panelDetails.Controls.Add(this.btnViewInvoice);
            this.panelDetails.Controls.Add(this.btnPrint);
            this.panelDetails.Controls.Add(this.btnRefresh);

            //
            // panelPreview contents
            //
            this.panelPreview.Controls.Add(this.lblInvoicePreview);
            this.panelPreview.Controls.Add(this.txtInvoicePreview);

            //
            // panelGrid contents
            //
            this.panelGrid.Controls.Add(this.dgvBills);

            //
            // BillingForm
            //
            this.ClientSize = new Size(1100, 700);
            this.Text = "Billing Management";
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Name = "BillingForm";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelPreview);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelPreview.ResumeLayout(false);
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