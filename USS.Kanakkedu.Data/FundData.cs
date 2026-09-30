using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public class FundData : IFundData
    {
        private readonly KanakkeduDBContext db;

        public FundData(KanakkeduDBContext dBContext)
        {
            db = dBContext;
        }

        public List<Fund> GetAll()
        {
            return db.Funds.ToList();
        }
    }
}
