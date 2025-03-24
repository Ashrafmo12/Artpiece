using Artpiece.DTOs;
using Artpiece.Models;

namespace Artpiece.Reposatory.ArtpieceRepo
{
    public interface IArtpiece
    {
        public void Add(Arts arts); 
        public  IList<Arts> GetArts();  
    }
}
