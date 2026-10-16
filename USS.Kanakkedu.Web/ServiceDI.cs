namespace USS.Kanakkedu.Web
{
    public static class ServiceDI
    {
        public static void AddServiceDI(this IServiceCollection services)
        {
            services.AddScoped<FundService>();
            services.AddScoped<JournalTypeService>();

                        services.AddScoped<FundService>();
                        services.AddScoped<ACYearService>();
                        services.AddScoped<ACGroupService>();
                        services.AddScoped<LedgerService>();
                        services.AddScoped<LedgerBalanceService>();
                        services.AddScoped<JournalService>();
                        services.AddScoped<JournalDetailService>();
                        services.AddScoped<PaymentService>();
                        services.AddScoped<TransactionTypeService>();
                        services.AddScoped<ChequeDetailService>();
                        services.AddScoped<ReceiptService>();
                        services.AddScoped<JournalTypeService>();
                    }
    }
}
