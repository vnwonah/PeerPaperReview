using PeerPaperReview.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeerPaperReview.Services
{
    public class PaperService
    {
        public async Task<IEnumerable<Paper>> GetPapers()
        {
            return new List<Paper>
            {
                new Paper
                {
                    Title = "A review of the stochastic process",
                    Body = "Lorem ipsom sita dolor ameh"
                }
            };
        }
    }
}
