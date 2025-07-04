﻿namespace SISApp.entity
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public Student Student { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment() { }

        public Payment(int paymentId, Student student, decimal amount, DateTime paymentDate)
        {
            PaymentId = paymentId;
            Student = student;
            Amount = amount;
            PaymentDate = paymentDate;
        }
    }
}
