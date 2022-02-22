﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyTrade.Models
{
    public class UserWallet
    {

        public string LoginId { get; set; }
        public string Amount { get; set; }
        public string PaymentMode { get; set; }
        public string DDChequeNo { get; set; }
        public string DDChequeDate { get; set; }
        public string BankBranch { get; set; }
        public string BankName { get; set; }
        public string AddedBy { get; set; }
        public string ReferBy { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CrAmount { get; set; }
        public string DrAmount { get; set; }
        public string Narration { get; set; }
        public string TransactionDate { get; set; }
        public string RoiWalletId { get; set; }
        public string Name { get; set; }
        public string TopUpAmount { get; set; }
        public string Date { get; set; }
        public string ROIId { get; set; }
        public string ROI { get; set; }
        public string FK_UserId { get; set; }
        public List<UserWallet> lstTps { get; set; }
        public List<UserWallet> lstROIIncome { get; set; }
        public List<UserWallet> lstROI { get; set; }
        public DataSet GetMemberDetails()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@LoginId", ReferBy),

                                  };
            DataSet ds = DBHelper.ExecuteQuery("GetUserName", para);

            return ds;
        }

        public DataSet SaveEwalletRequest()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@LoginId", LoginId),
                                      new SqlParameter("@Amount", Amount),
                                      new SqlParameter("@PaymentMode", PaymentMode) ,
                                      new SqlParameter("@DDChequeNo", DDChequeNo) ,
                                      new SqlParameter("@DDChequeDate", DDChequeDate) ,
                                      new SqlParameter("@BankBranch", BankBranch) ,
                                          new SqlParameter("@BankName", BankName),
                                            new SqlParameter("@AddedBy", AddedBy)
                                     };
            DataSet ds = DBHelper.ExecuteQuery("EwalletRequest", para);
            return ds;
        }

        public DataSet GetPaymentMode()
        {

            DataSet ds = DBHelper.ExecuteQuery("GetPaymentModeList");

            return ds;
        }
        public DataSet GetROIWalletDetails()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@FK_UserId", FK_UserId),
                                      new SqlParameter("@LoginId", LoginId),
                                      new SqlParameter("@FromDate", FromDate),
                                      new SqlParameter("@ToDate", ToDate)
                                     };

            DataSet ds = DBHelper.ExecuteQuery("GetROIWalletDetails", para);
            return ds;
        }
        public DataSet GetROIIncomeReportsDetails()
        {

            SqlParameter[] para = {
                  new SqlParameter("@Fk_UserId", FK_UserId),
                                      new SqlParameter("@FromDate", FromDate),
                                      new SqlParameter("@ToDate", ToDate)
                                     };
            DataSet ds = DBHelper.ExecuteQuery("GetROIIncomeReportsDetails",para);
            return ds;
        }

        public DataSet GetROIDetails()
        {
            DataSet ds = DBHelper.ExecuteQuery("GetROIDetails");
            return ds;
        }




    }
}