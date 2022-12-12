using ProiectWAD.Interfaces.Repository;
using ProiectWAD.Models;

namespace ProiectWAD.Repository
{
    internal class SellersRepository : BaseRepository<Seller>, ISellersRepository
    {
        public SellersRepository(ProiectWADDBContext dbContext) : base(dbContext)
        {

        }
    }
}
