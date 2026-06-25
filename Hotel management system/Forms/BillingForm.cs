using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using Hotel_management_system.BLL;
using Hotel_management_system.Models;
using Hotel_management_system.Helpers;
using Hotel_management_system.DAL;
using Guna.UI2.WinForms;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    public partial class BillingForm : GlassFormBase
    {
        private BillingManager billingManager = new BillingManager();
        private BookingDAL bookingDAL = new BookingDAL();
        private GuestDAL guestDAL = new GuestDAL();
        private RoomDAL roomDAL = new RoomDAL();
        private List<Bill> billList = new List<Bill>();
        private PrintDocument printDocument = new PrintDocument();
        private string invoiceText = "";

        public BillingForm()
        {
            InitializeComponent();
            LoadBills();
            SetupDataGridView();
            SetupPrintDocument();
        }

        private void SetupDataGridView()
        {
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.MultiSelect = false;
            dgvBills.ReadOnly = true;
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToDeleteRows = false;
            dgvBills.SelectionChanged += DgvBills_SelectionChanged;
        }

        private void SetupPrintDocument()
        {
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void LoadBills()
        {
            try
            {
                billList = billingManager.GetAllBills();
                dgvBills.DataSource = null;
                dgvBills.DataSource = billList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dgvBills.Columns.Count > 0)
            {
                dgvBills.Columns["BillID"].HeaderText = "ID";
                dgvBills.Columns["InvoiceNumber"].HeaderText = "INVOICE #";
                dgvBills.Columns["BookingID"].HeaderText = "BOOKING ID";
                dgvBills.Columns["NumberOfNights"].HeaderText = "NIGHTS";
                dgvBills.Columns["TotalAmount"].HeaderText = "TOTAL";
                dgvBills.Columns["PaymentStatus"].HeaderText = "STATUS";
                dgvBills.Columns["GeneratedAt"].HeaderText = "GENERATED";

                dgvBills.ColumnHeadersHeight = 35;
                dgvBills.RowTemplate.Height = 30;
                dgvBills.RowHeadersVisible = false;
                dgvBills.BackgroundColor = Color.White;
                dgvBills.GridColor = Color.FromArgb(230, 230, 230);
                dgvBills.BorderStyle = BorderStyle.None;
                dgvBills.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvBills.Columns["RatePerNight"].DefaultCellStyle.Format = "N2";
                dgvBills.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
                dgvBills.Columns["AdditionalCharges"].DefaultCellStyle.Format = "N2";
                dgvBills.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";

                dgvBills.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 26, 34);
                dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvBills.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 26, 34);
                dgvBills.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgvBills.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                dgvBills.DefaultCellStyle.BackColor = Color.White;
                dgvBills.DefaultCellStyle.SelectionBackColor = Color.FromArgb(77, 124, 254);
                dgvBills.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvBills.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgvBills.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

                foreach (DataGridViewRow row in dgvBills.Rows)
                {
                    string status = row.Cells["PaymentStatus"].Value?.ToString() ?? "";
                    if (status == "Paid")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
                    }
                }
            }
        }

        private void DgvBills_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count > 0)
            {
                var bill = (Bill)dgvBills.SelectedRows[0].DataBoundItem;
                DisplayBillDetails(bill);
            }
        }

        private void DisplayBillDetails(Bill bill)
        {
            txtBillID.Text = bill.BillID.ToString();
            txtInvoiceNumber.Text = bill.InvoiceNumber;
            txtNumberOfNights.Text = bill.NumberOfNights.ToString();
            txtRatePerNight.Text = bill.RatePerNight.ToString("F2");
            txtSubTotal.Text = bill.SubTotal.ToString("F2");
            txtAdditionalCharges.Text = bill.AdditionalCharges.ToString("F2");
            txtTotalAmount.Text = bill.TotalAmount.ToString("F2");
            txtPaymentStatus.Text = bill.PaymentStatus;
            txtGeneratedAt.Text = bill.GeneratedAt.ToString("yyyy-MM-dd HH:mm");

            if (bill.PaidAt.HasValue)
            {
                txtPaidAt.Text = bill.PaidAt.Value.ToString("yyyy-MM-dd HH:mm");
            }
            else
            {
                txtPaidAt.Text = "N/A";
            }
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBillID.Text))
            {
                MessageBox.Show("Please select a bill to mark as paid.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Mark this bill as paid?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var payResult = billingManager.MarkAsPaid(int.Parse(txtBillID.Text));
                    MessageBox.Show(payResult.message, "Billing",
                        MessageBoxButtons.OK, payResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                    if (payResult.success)
                    {
                        LoadBills();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBillID.Text))
            {
                MessageBox.Show("Please select a bill to view invoice.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bill = billingManager.GetBillById(int.Parse(txtBillID.Text));
                var booking = bookingDAL.GetBookingById(bill.BookingID);
                var guest = guestDAL.GetGuestById(booking.GuestID);
                var room = roomDAL.GetRoomById(booking.RoomID);

                invoiceText = InvoiceHelper.GenerateInvoiceText(bill, booking, guest, room);
                txtInvoicePreview.Text = invoiceText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating invoice: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(invoiceText))
            {
                MessageBox.Show("Please view the invoice first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (!string.IsNullOrEmpty(invoiceText))
            {
                using (Font font = new Font("Courier New", 10))
                {
                    e.Graphics.DrawString(invoiceText, font, Brushes.Black, 50, 50);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBills();
            ClearFields();
        }

        private void ClearFields()
        {
            txtBillID.Text = "";
            txtInvoiceNumber.Text = "";
            txtNumberOfNights.Text = "";
            txtRatePerNight.Text = "";
            txtSubTotal.Text = "";
            txtAdditionalCharges.Text = "";
            txtTotalAmount.Text = "";
            txtPaymentStatus.Text = "";
            txtGeneratedAt.Text = "";
            txtPaidAt.Text = "";
            txtInvoicePreview.Text = "";
            invoiceText = "";
        }
    }
}