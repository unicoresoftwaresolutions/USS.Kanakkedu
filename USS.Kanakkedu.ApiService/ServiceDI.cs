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

            services.AddScoped<IJournalTypeData, JournalTypeData>();
            services.AddScoped<IJournalTypeBusiness, JournalTypeBusiness>();
        }
    }
}
