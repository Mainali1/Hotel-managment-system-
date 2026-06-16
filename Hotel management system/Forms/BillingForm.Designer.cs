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
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Text = "Billing Management";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            lblTitle = new Label();
            lblTitle.Text = "BILLING MANAGEMENT";
            lblTitle.Font = new System.Drawing.Font("Courier New", 16, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Size = new System.Drawing.Size(350, 30);
            this.Controls.Add(lblTitle);

            panelDetails = new Panel();
            panelDetails.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelDetails.Location = new System.Drawing.Point(20, 60);
            panelDetails.Size = new System.Drawing.Size(280, 300);
            this.Controls.Add(panelDetails);

            panelPreview = new Panel();
            panelPreview.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelPreview.Location = new System.Drawing.Point(20, 370);
            panelPreview.Size = new System.Drawing.Size(1060, 310);
            this.Controls.Add(panelPreview);

            panelGrid = new Panel();
            panelGrid.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelGrid.Location = new System.Drawing.Point(320, 60);
            panelGrid.Size = new System.Drawing.Size(760, 300);
            this.Controls.Add(panelGrid);

            int labelX = 10;
            int textX = 10;
            int textWidth = 250;
            int startY = 15;
            int gap = 28;

            lblBillID = CreateLabel("BILL ID:", labelX, startY);
            panelDetails.Controls.Add(lblBillID);
            txtBillID = CreateReadOnlyTextBox(textX, startY + 15, textWidth);
            panelDetails.Controls.Add(txtBillID);

            lblInvoiceNumber = CreateLabel("INVOICE #:", labelX, startY + gap);
            panelDetails.Controls.Add(lblInvoiceNumber);
            txtInvoiceNumber = CreateReadOnlyTextBox(textX, startY + gap + 15, textWidth);
            panelDetails.Controls.Add(txtInvoiceNumber);

            lblNumberOfNights = CreateLabel("NIGHTS:", labelX, startY + gap * 2);
            panelDetails.Controls.Add(lblNumberOfNights);
            txtNumberOfNights = CreateReadOnlyTextBox(textX, startY + gap * 2 + 15, textWidth);
            panelDetails.Controls.Add(txtNumberOfNights);

            lblRatePerNight = CreateLabel("RATE/NIGHT:", labelX, startY + gap * 3);
            panelDetails.Controls.Add(lblRatePerNight);
            txtRatePerNight = CreateReadOnlyTextBox(textX, startY + gap * 3 + 15, textWidth);
            panelDetails.Controls.Add(txtRatePerNight);

            lblSubTotal = CreateLabel("SUB TOTAL:", labelX, startY + gap * 4);
            panelDetails.Controls.Add(lblSubTotal);
            txtSubTotal = CreateReadOnlyTextBox(textX, startY + gap * 4 + 15, textWidth);
            panelDetails.Controls.Add(txtSubTotal);

            lblAdditionalCharges = CreateLabel("ADDITIONAL:", labelX, startY + gap * 5);
            panelDetails.Controls.Add(lblAdditionalCharges);
            txtAdditionalCharges = CreateReadOnlyTextBox(textX, startY + gap * 5 + 15, textWidth);
            panelDetails.Controls.Add(txtAdditionalCharges);

            lblTotalAmount = CreateLabel("TOTAL:", labelX, startY + gap * 6);
            lblTotalAmount.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            panelDetails.Controls.Add(lblTotalAmount);
            txtTotalAmount = CreateReadOnlyTextBox(textX, startY + gap * 6 + 15, textWidth);
            txtTotalAmount.Font = new System.Drawing.Font("Courier New", 12, System.Drawing.FontStyle.Bold);
            panelDetails.Controls.Add(txtTotalAmount);

            lblPaymentStatus = CreateLabel("STATUS:", labelX, startY + gap * 7 + 10);
            lblPaymentStatus.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            panelDetails.Controls.Add(lblPaymentStatus);
            txtPaymentStatus = CreateReadOnlyTextBox(textX, startY + gap * 7 + 25, textWidth);
            txtPaymentStatus.Font = new System.Drawing.Font("Courier New", 11, System.Drawing.FontStyle.Bold);
            panelDetails.Controls.Add(txtPaymentStatus);

            lblGeneratedAt = CreateLabel("GENERATED:", labelX, startY + gap * 8 + 25);
            panelDetails.Controls.Add(lblGeneratedAt);
            txtGeneratedAt = CreateReadOnlyTextBox(textX, startY + gap * 8 + 40, textWidth);
            panelDetails.Controls.Add(txtGeneratedAt);

            lblPaidAt = CreateLabel("PAID AT:", labelX, startY + gap * 9 + 40);
            panelDetails.Controls.Add(lblPaidAt);
            txtPaidAt = CreateReadOnlyTextBox(textX, startY + gap * 9 + 55, textWidth);
            panelDetails.Controls.Add(txtPaidAt);

            int btnWidth = 130;
            int btnHeight = 40;
            int btnX = 10;
            int btnStartY = 265;

            btnMarkPaid = new Button();
            btnMarkPaid.Text = "MARK PAID";
            btnMarkPaid.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnMarkPaid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(50, 150, 50);
            btnMarkPaid.FlatStyle = FlatStyle.Flat;
            btnMarkPaid.FlatAppearance.BorderSize = 0;
            btnMarkPaid.Location = new System.Drawing.Point(btnX, btnStartY);
            btnMarkPaid.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnMarkPaid.Cursor = Cursors.Hand;
            btnMarkPaid.Click += new EventHandler(btnMarkPaid_Click);
            panelDetails.Controls.Add(btnMarkPaid);

            btnViewInvoice = new Button();
            btnViewInvoice.Text = "VIEW INVOICE";
            btnViewInvoice.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnViewInvoice.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(50, 50, 150);
            btnViewInvoice.FlatStyle = FlatStyle.Flat;
            btnViewInvoice.FlatAppearance.BorderSize = 0;
            btnViewInvoice.Location = new System.Drawing.Point(btnX + btnWidth + 5, btnStartY);
            btnViewInvoice.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnViewInvoice.Cursor = Cursors.Hand;
            btnViewInvoice.Click += new EventHandler(btnViewInvoice_Click);
            panelDetails.Controls.Add(btnViewInvoice);

            btnPrint = new Button();
            btnPrint.Text = "PRINT";
            btnPrint.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnPrint.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Location = new System.Drawing.Point(btnX, btnStartY + 45);
            btnPrint.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Click += new EventHandler(btnPrint_Click);
            panelDetails.Controls.Add(btnPrint);

            btnRefresh = new Button();
            btnRefresh.Text = "REFRESH";
            btnRefresh.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 1;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnRefresh.Location = new System.Drawing.Point(btnX + btnWidth + 5, btnStartY + 45);
            btnRefresh.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Click += new EventHandler(btnRefresh_Click);
            panelDetails.Controls.Add(btnRefresh);

            lblInvoicePreview = new Label();
            lblInvoicePreview.Text = "INVOICE PREVIEW:";
            lblInvoicePreview.Font = new System.Drawing.Font("Courier New", 10, System.Drawing.FontStyle.Bold);
            lblInvoicePreview.Location = new System.Drawing.Point(10, 10);
            lblInvoicePreview.Size = new System.Drawing.Size(200, 20);
            panelPreview.Controls.Add(lblInvoicePreview);

            txtInvoicePreview = new TextBox();
            txtInvoicePreview.Location = new System.Drawing.Point(10, 35);
            txtInvoicePreview.Size = new System.Drawing.Size(1040, 265);
            txtInvoicePreview.Font = new System.Drawing.Font("Courier New", 9);
            txtInvoicePreview.Multiline = true;
            txtInvoicePreview.ScrollBars = ScrollBars.Vertical;
            txtInvoicePreview.ReadOnly = true;
            txtInvoicePreview.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtInvoicePreview.Name = "txtInvoicePreview";
            panelPreview.Controls.Add(txtInvoicePreview);

            dgvBills = new DataGridView();
            dgvBills.Dock = DockStyle.Fill;
            dgvBills.Location = new System.Drawing.Point(0, 0);
            dgvBills.Size = new System.Drawing.Size(760, 300);
            dgvBills.Name = "dgvBills";
            dgvBills.BorderStyle = BorderStyle.None;
            panelGrid.Controls.Add(dgvBills);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
        }

        private Label CreateLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(120, 15);
            return lbl;
        }

        private TextBox CreateReadOnlyTextBox(int x, int y, int width)
        {
            TextBox txt = new TextBox();
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(width, 25);
            txt.Font = new System.Drawing.Font("Courier New", 10);
            txt.ReadOnly = true;
            txt.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            return txt;
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