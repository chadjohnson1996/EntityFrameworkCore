using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Edata
    {
        public Edata()
        {
            AccountsAchDestRoutingNumE = new HashSet<Accounts>();
            AccountsAchOriginDfiIdE = new HashSet<Accounts>();
            AccountsAchOriginRoutingNumE = new HashSet<Accounts>();
            AccountsBankAccountNumE = new HashSet<Accounts>();
            AccountsDirDepExpHeaderE = new HashSet<Accounts>();
            AccountsMicrMicrPrint1E = new HashSet<AccountsMicr>();
            AccountsMicrMicrPrint2E = new HashSet<AccountsMicr>();
            AccountsMicrMicrPrint3E = new HashSet<AccountsMicr>();
            AccountsMicrMicrRoutingNoE = new HashSet<AccountsMicr>();
            AccountsMicrRoutingAE = new HashSet<AccountsMicr>();
            AccountsMicrRoutingBE = new HashSet<AccountsMicr>();
            AccountsMicrRoutingCE = new HashSet<AccountsMicr>();
            AccountsVndDirPayExpHeaderE = new HashSet<Accounts>();
            ControlAp = new HashSet<ControlAp>();
            EmpAcaCoveredIndividuals = new HashSet<EmpAcaCoveredIndividuals>();
            EmpDirectDepositBankAccountNoE = new HashSet<EmpDirectDeposit>();
            EmpDirectDepositBankRoutingNoE = new HashSet<EmpDirectDeposit>();
            EmployeesApprenticeCodeE = new HashSet<Employees>();
            EmployeesDriverLicenseNumberE = new HashSet<Employees>();
            EmployeesOhsaCertNumE = new HashSet<Employees>();
            EmployeesOhsaTradeLicenseE = new HashSet<Employees>();
            EmployeesSsNoE = new HashSet<Employees>();
            EmployeesSwacTwicIdE = new HashSet<Employees>();
            EmployeesUnionIdNumE = new HashSet<Employees>();
            HisChkStub1 = new HashSet<HisChkStub1>();
            HisChkStub4 = new HashSet<HisChkStub4>();
            HisChkStubExtended = new HashSet<HisChkStubExtended>();
            HisDirectDepositDistBankAccountNoE = new HashSet<HisDirectDepositDist>();
            HisDirectDepositDistBankRoutingNoE = new HashSet<HisDirectDepositDist>();
            PayChkStub1 = new HashSet<PayChkStub1>();
            PayChkStub4 = new HashSet<PayChkStub4>();
            PayChkStubExtended = new HashSet<PayChkStubExtended>();
            PayDirectDepositDistBankAccountNoE = new HashSet<PayDirectDepositDist>();
            PayDirectDepositDistBankRoutingNoE = new HashSet<PayDirectDepositDist>();
            VendorDirectPaymentsBankAccountNoE = new HashSet<VendorDirectPayments>();
            VendorDirectPaymentsBankRoutingNoE = new HashSet<VendorDirectPayments>();
            Vendors = new HashSet<Vendors>();
        }

        public int Id { get; set; }
        public string Data { get; set; }

        public ICollection<Accounts> AccountsAchDestRoutingNumE { get; set; }
        public ICollection<Accounts> AccountsAchOriginDfiIdE { get; set; }
        public ICollection<Accounts> AccountsAchOriginRoutingNumE { get; set; }
        public ICollection<Accounts> AccountsBankAccountNumE { get; set; }
        public ICollection<Accounts> AccountsDirDepExpHeaderE { get; set; }
        public ICollection<AccountsMicr> AccountsMicrMicrPrint1E { get; set; }
        public ICollection<AccountsMicr> AccountsMicrMicrPrint2E { get; set; }
        public ICollection<AccountsMicr> AccountsMicrMicrPrint3E { get; set; }
        public ICollection<AccountsMicr> AccountsMicrMicrRoutingNoE { get; set; }
        public ICollection<AccountsMicr> AccountsMicrRoutingAE { get; set; }
        public ICollection<AccountsMicr> AccountsMicrRoutingBE { get; set; }
        public ICollection<AccountsMicr> AccountsMicrRoutingCE { get; set; }
        public ICollection<Accounts> AccountsVndDirPayExpHeaderE { get; set; }
        public ICollection<ControlAp> ControlAp { get; set; }
        public ICollection<EmpAcaCoveredIndividuals> EmpAcaCoveredIndividuals { get; set; }
        public ICollection<EmpDirectDeposit> EmpDirectDepositBankAccountNoE { get; set; }
        public ICollection<EmpDirectDeposit> EmpDirectDepositBankRoutingNoE { get; set; }
        public ICollection<Employees> EmployeesApprenticeCodeE { get; set; }
        public ICollection<Employees> EmployeesDriverLicenseNumberE { get; set; }
        public ICollection<Employees> EmployeesOhsaCertNumE { get; set; }
        public ICollection<Employees> EmployeesOhsaTradeLicenseE { get; set; }
        public ICollection<Employees> EmployeesSsNoE { get; set; }
        public ICollection<Employees> EmployeesSwacTwicIdE { get; set; }
        public ICollection<Employees> EmployeesUnionIdNumE { get; set; }
        public ICollection<HisChkStub1> HisChkStub1 { get; set; }
        public ICollection<HisChkStub4> HisChkStub4 { get; set; }
        public ICollection<HisChkStubExtended> HisChkStubExtended { get; set; }
        public ICollection<HisDirectDepositDist> HisDirectDepositDistBankAccountNoE { get; set; }
        public ICollection<HisDirectDepositDist> HisDirectDepositDistBankRoutingNoE { get; set; }
        public ICollection<PayChkStub1> PayChkStub1 { get; set; }
        public ICollection<PayChkStub4> PayChkStub4 { get; set; }
        public ICollection<PayChkStubExtended> PayChkStubExtended { get; set; }
        public ICollection<PayDirectDepositDist> PayDirectDepositDistBankAccountNoE { get; set; }
        public ICollection<PayDirectDepositDist> PayDirectDepositDistBankRoutingNoE { get; set; }
        public ICollection<VendorDirectPayments> VendorDirectPaymentsBankAccountNoE { get; set; }
        public ICollection<VendorDirectPayments> VendorDirectPaymentsBankRoutingNoE { get; set; }
        public ICollection<Vendors> Vendors { get; set; }
    }
}
