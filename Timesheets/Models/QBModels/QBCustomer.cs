using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.Models
{
    public class QBCustomer
    {
        public string ListID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string ParentRefListID { get; set; }
        public string ParentRefFullName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Sublevel { get; set; }
        public string CompanyName { get; set; }

        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BillAddressAddr1 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressState { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public string Contact { get; set; }

        [NotMapped]
        public Nullable<System.DateTime> TimeCreated { get; set; }
        [NotMapped]
        public Nullable<System.DateTime> TimeModified { get; set; }
        [NotMapped]
        public string EditSequence { get; set; }
        [NotMapped]
        public string ClassRefListID { get; set; }
        [NotMapped]
        public string ClassRefFullName { get; set; }
        [NotMapped]
        public string BillAddressAddr2 { get; set; }
        [NotMapped]
        public string BillAddressAddr3 { get; set; }
        [NotMapped]
        public string BillAddressAddr4 { get; set; }
        [NotMapped]
        public string BillAddressAddr5 { get; set; }
        [NotMapped]
        public string BillAddressProvince { get; set; }
        [NotMapped]
        public string BillAddressCounty { get; set; }
        [NotMapped]
        public string BillAddressCountry { get; set; }
        [NotMapped]
        public string BillAddressNote { get; set; }
        [NotMapped]
        public string BillAddressBlockAddr1 { get; set; }
        [NotMapped]
        public string BillAddressBlockAddr2 { get; set; }
        [NotMapped]
        public string BillAddressBlockAddr3 { get; set; }
        [NotMapped]
        public string BillAddressBlockAddr4 { get; set; }
        [NotMapped]
        public string BillAddressBlockAddr5 { get; set; }
        [NotMapped]
        public string ShipAddressAddr1 { get; set; }
        [NotMapped]
        public string ShipAddressAddr2 { get; set; }
        [NotMapped]
        public string ShipAddressAddr3 { get; set; }
        [NotMapped]
        public string ShipAddressAddr4 { get; set; }
        [NotMapped]
        public string ShipAddressAddr5 { get; set; }
        [NotMapped]
        public string ShipAddressCity { get; set; }
        [NotMapped]
        public string ShipAddressState { get; set; }
        [NotMapped]
        public string ShipAddressProvince { get; set; }
        [NotMapped]
        public string ShipAddressCounty { get; set; }
        [NotMapped]
        public string ShipAddressPostalCode { get; set; }
        [NotMapped]
        public string ShipAddressCountry { get; set; }
        [NotMapped]
        public string ShipAddressNote { get; set; }
        [NotMapped]
        public string ShipAddressBlockAddr1 { get; set; }
        [NotMapped]
        public string ShipAddressBlockAddr2 { get; set; }
        [NotMapped]
        public string ShipAddressBlockAddr3 { get; set; }
        [NotMapped]
        public string ShipAddressBlockAddr4 { get; set; }
        [NotMapped]
        public string ShipAddressBlockAddr5 { get; set; }
        [NotMapped]
        public string AltPhone { get; set; }
        [NotMapped]
        public string AltContact { get; set; }
        [NotMapped]
        public string CustomerTypeRefListID { get; set; }
        [NotMapped]
        public string CustomerTypeRefFullName { get; set; }
        [NotMapped]
        public string TermsRefListID { get; set; }
        [NotMapped]
        public string TermsRefFullName { get; set; }
        [NotMapped]
        public string SalesRepRefListID { get; set; }
        [NotMapped]
        public string SalesRepRefFullName { get; set; }
        [NotMapped]
        public Nullable<decimal> Balance { get; set; }
        [NotMapped]
        public Nullable<decimal> TotalBalance { get; set; }
        [NotMapped]
        public Nullable<decimal> OpenBalance { get; set; }
        [NotMapped]
        public Nullable<System.DateTime> OpenBalanceDate { get; set; }
        [NotMapped]
        public string SalesTaxCodeRefListID { get; set; }
        [NotMapped]
        public string SalesTaxCodeRefFullName { get; set; }
        [NotMapped]
        public string TaxCodeRefListID { get; set; }
        [NotMapped]
        public string TaxCodeRefFullName { get; set; }
        [NotMapped]
        public string ItemSalesTaxRefListID { get; set; }
        [NotMapped]
        public string ItemSalesTaxRefFullName { get; set; }
        [NotMapped]
        public string SalesTaxCountry { get; set; }
        [NotMapped]
        public string ResaleNumber { get; set; }
        [NotMapped]
        public string AccountNumber { get; set; }
        [NotMapped]
        public string BusinessNumber { get; set; }
        [NotMapped]
        public Nullable<decimal> CreditLimit { get; set; }
        [NotMapped]
        public string PreferredPaymentMethodRefListID { get; set; }
        [NotMapped]
        public string PreferredPaymentMethodRefFullName { get; set; }
        [NotMapped]
        public string CreditCardInfoCreditCardNumber { get; set; }
        [NotMapped]
        public Nullable<int> CreditCardInfoExpirationMonth { get; set; }
        [NotMapped]
        public Nullable<int> CreditCardInfoExpirationYear { get; set; }
        [NotMapped]
        public string CreditCardInfoNameOnCard { get; set; }
        [NotMapped]
        public string CreditCardInfoCreditCardAddress { get; set; }
        [NotMapped]
        public string CreditCardInfoCreditCardPostalCode { get; set; }
        [NotMapped]
        public string JobStatus { get; set; }
        [NotMapped]
        public Nullable<System.DateTime> JobStartDate { get; set; }
        [NotMapped]
        public Nullable<System.DateTime> JobProjectedEndDate { get; set; }
        [NotMapped]
        public Nullable<System.DateTime> JobEndDate { get; set; }
        [NotMapped]
        public string JobDesc { get; set; }
        [NotMapped]
        public string JobTypeRefListID { get; set; }
        [NotMapped]
        public string JobTypeRefFullName { get; set; }
        [NotMapped]
        public string Notes { get; set; }
        [NotMapped]
        public string PreferredDeliveryMethod { get; set; }
        [NotMapped]
        public bool IsUsingCustomerTaxCode { get; set; }
        [NotMapped]
        public string PriceLevelRefListID { get; set; }
        [NotMapped]
        public string PriceLevelRefFullName { get; set; }
        [NotMapped]
        public string ExternalGUID { get; set; }
        [NotMapped]
        public string TaxRegistrationNumber { get; set; }
        [NotMapped]
        public string CurrencyRefListID { get; set; }
        [NotMapped]
        public string CurrencyRefFullName { get; set; }
    }
}
