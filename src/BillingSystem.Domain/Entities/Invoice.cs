using System.Diagnostics.Contracts;
using BillingSystem.Domain.Enums;

namespace BillingSystem.Domain.Entities;

public class Invoice
{
    public Guid Id {get; private set;}
    public string InvoiceNumber {get; private set;} = string.Empty;
    public Guid TenantId {get; private set;}
    public decimal Amount {get; private set;}
    public DateTime IssueDate {get; private set;}
    public DateTime DueDate {get; private set;}
    public InvoiceStatus Status {get; private set;}
    public Invoice(Guid tenantId,string invoiceNumber,decimal amount,DateTime dueDate)
    {
        Id = Guid.NewGuid();
        TenantId = tenantId;
        InvoiceNumber = invoiceNumber;
        Amount = amount;
        IssueDate = DateTime.UtcNow;
        DueDate = dueDate;
        Status = InvoiceStatus.Draft;
    }

    public void MarkAsIssued()
    {
            if (Status != InvoiceStatus.Draft) 
            throw new InvalidOperationException("Only draft invoices can be issued.");

            Status = InvoiceStatus.Issued;   
    }

    public void MarkAsPaid()
    {
        if (Status != InvoiceStatus.Issued && Status != InvoiceStatus.Overdue) 
        throw new InvalidOperationException("Invoice cannot be paid in current state.");

        Status = InvoiceStatus.Paid;
    }

    public void Cancel()
    {
        if (Status != InvoiceStatus.Paid) 
        throw new InvalidOperationException("Paid invoice cannot be cancelled.");

        Status = InvoiceStatus.Cancelled;


    }
}