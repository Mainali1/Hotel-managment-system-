using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hotel_management_system.Models;

namespace Hotel_management_system.DAL
{
    public class BillingDAL
    {
        public List<Bill> GetAllBills()
        {
            List<Bill> bills = new List<Bill>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Billing ORDER BY GeneratedAt DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bills.Add(MapBill(reader));
                    }
                }
            }
            return bills;
        }

        public Bill GetBillById(int billId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Billing WHERE BillID = @BillID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BillID", billId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapBill(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Bill GetBillByBookingId(int bookingId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Billing WHERE BookingID = @BookingID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapBill(reader);
                        }
                    }
                }
            }
            return null;
        }

        public decimal GetTodayRevenue()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT ISNULL(SUM(TotalAmount), 0) FROM tbl_Billing 
                                 WHERE CAST(GeneratedAt AS DATE) = CAST(GETDATE() AS DATE) 
                                 AND PaymentStatus = 'Paid'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
        }

        public decimal GetMonthlyRevenue()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT ISNULL(SUM(TotalAmount), 0) FROM tbl_Billing 
                                 WHERE MONTH(GeneratedAt) = MONTH(GETDATE()) 
                                 AND YEAR(GeneratedAt) = YEAR(GETDATE())
                                 AND PaymentStatus = 'Paid'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
        }

        public int AddBill(Bill bill)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO tbl_Billing 
                                (BookingID, InvoiceNumber, RatePerNight, NumberOfNights, SubTotal, 
                                 AdditionalCharges, TotalAmount, PaymentStatus)
                                VALUES (@BookingID, @InvoiceNumber, @RatePerNight, @NumberOfNights, 
                                        @SubTotal, @AdditionalCharges, @TotalAmount, @PaymentStatus);
                                SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bill.BookingID);
                    cmd.Parameters.AddWithValue("@InvoiceNumber", bill.InvoiceNumber);
                    cmd.Parameters.AddWithValue("@RatePerNight", bill.RatePerNight);
                    cmd.Parameters.AddWithValue("@NumberOfNights", bill.NumberOfNights);
                    cmd.Parameters.AddWithValue("@SubTotal", bill.SubTotal);
                    cmd.Parameters.AddWithValue("@AdditionalCharges", bill.AdditionalCharges);
                    cmd.Parameters.AddWithValue("@TotalAmount", bill.TotalAmount);
                    cmd.Parameters.AddWithValue("@PaymentStatus", bill.PaymentStatus);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool UpdatePaymentStatus(int billId, string status)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE tbl_Billing SET PaymentStatus = @Status";
                if (status == "Paid")
                {
                    query += ", PaidAt = @PaidAt";
                }
                query += " WHERE BillID = @BillID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@BillID", billId);
                    if (status == "Paid")
                    {
                        cmd.Parameters.AddWithValue("@PaidAt", DateTime.Now);
                    }
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Bill MapBill(SqlDataReader reader)
        {
            return new Bill
            {
                BillID = (int)reader["BillID"],
                BookingID = (int)reader["BookingID"],
                InvoiceNumber = reader["InvoiceNumber"].ToString(),
                RatePerNight = (decimal)reader["RatePerNight"],
                NumberOfNights = (int)reader["NumberOfNights"],
                SubTotal = (decimal)reader["SubTotal"],
                AdditionalCharges = (decimal)reader["AdditionalCharges"],
                TotalAmount = (decimal)reader["TotalAmount"],
                PaymentStatus = reader["PaymentStatus"].ToString(),
                GeneratedAt = (DateTime)reader["GeneratedAt"],
                PaidAt = reader["PaidAt"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["PaidAt"]
            };
        }
    }
}