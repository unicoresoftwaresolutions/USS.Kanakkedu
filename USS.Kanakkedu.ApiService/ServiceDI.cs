

using USS.Kanakkedu.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data;
using USS.Kanakkedu.Data.Interface;

namespace USS.Kanakkedu.ApiService
{
    public static class ServiceDI
    {
        public static void AddServiceDI(this IServiceCollection services)
        {

            
            services.AddScoped<IFundData, FundData>();
            services.AddScoped<IFundBusiness, FundBusiness>();
            
            services.AddScoped<IACYearData, ACYearData>();
            services.AddScoped<IACYearBusiness, ACYearBusiness>();
            
            services.AddScoped<IACGroupData, ACGroupData>();
            services.AddScoped<IACGroupBusiness, ACGroupBusiness>();
            
            services.AddScoped<ILedgerData, LedgerData>();
            services.AddScoped<ILedgerBusiness, LedgerBusiness>();
            
            services.AddScoped<ILedgerBalanceData, LedgerBalanceData>();
            services.AddScoped<ILedgerBalanceBusiness, LedgerBalanceBusiness>();
            
            services.AddScoped<IJournalData, JournalData>();
            services.AddScoped<IJournalBusiness, JournalBusiness>();
            
            services.AddScoped<IJournalDetailData, JournalDetailData>();
            services.AddScoped<IJournalDetailBusiness, JournalDetailBusiness>();
            
            services.AddScoped<IPaymentData, PaymentData>();
            services.AddScoped<IPaymentBusiness, PaymentBusiness>();
            
            services.AddScoped<ITransactionTypeData, TransactionTypeData>();
            services.AddScoped<ITransactionTypeBusiness, TransactionTypeBusiness>();
            
            services.AddScoped<IChequeDetailData, ChequeDetailData>();
            services.AddScoped<IChequeDetailBusiness, ChequeDetailBusiness>();
            
            services.AddScoped<IReceiptData, ReceiptData>();
            services.AddScoped<IReceiptBusiness, ReceiptBusiness>();
            
            services.AddScoped<IJournalTypeData, JournalTypeData>();
            services.AddScoped<IJournalTypeBusiness, JournalTypeBusiness>();
            
        }
    }
}
