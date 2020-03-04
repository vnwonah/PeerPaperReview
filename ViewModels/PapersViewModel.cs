using PeerPaperReview.Entities;
using PeerPaperReview.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeerPaperReview.ViewModels
{
    public class PapersViewModel : MasterPageViewModel
    {
        private readonly PaperService _paperService;
        public IEnumerable<Paper> Papers { get; set; }
        public PapersViewModel(PaperService paperService)
        {
            _paperService = paperService;
        }

        public override async Task PreRender()
        {
            Papers = await _paperService.GetPapers();
            await base.PreRender();
        }
    }
}
