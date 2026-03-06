namespace BillingSystem.Domain.Enums;

public enum InvoiceStatus
{
    Draft = 0, //created but not sent
    Issued = 1,//active invoice, waiting for payment
    Paid = 1,//payment completed
    Overdue = 3,//due date passed
    Cancelled = 4 //invalid invoice
}