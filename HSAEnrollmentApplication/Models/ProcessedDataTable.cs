﻿using System;
using System.Data;

namespace HSAEnrollmentApplication.Models
{
    public class ProcessedDataTable
    {
        public DataTable AssessmentTable()
        {
            DataTable table = new DataTable("ProcessedData");
            table.Columns.Add("Status", typeof(AssessmentStatus));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("DOB", typeof(string));
            table.Columns.Add("PlanType", typeof(PlanType));
            table.Columns.Add("EffectiveDate", typeof(string));

            return table;
        }
    }
}
