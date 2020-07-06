using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzim.Entities.Concrete;

namespace Tanzim.Business.Abstract
{
    public interface ITrackService
    {
        void Add(Track track);
        void Delete(Track track);
        void Update(Track track);


        //OUTER METHODS 
        void SubmitTrackAndCategoryId(int categoryId,Track track);
        List<Track> GetAllTracksOfCurrentUser();
        List<Track> GetAllTracksOfCurrentUserByCategoryId(int categoryId);



        //INNER METHODS
        void SubmitTrackByUserIdAndCategoryId(int userId, int categoryId,Track track);



        List<Track> GetAllTracksByUserId(int userId);
        List<Track> GetAllTracksByUserIdAndCategoryId(int userId,int categoryId);
        List<Track> GetAllTracksByUserIdAndStartTimeDay(int userId, DateTime startTime);
        List<Track> GetAllTracksBetweenFromTimeToTimeByUserId(int userId, DateTime fromTime, DateTime toTime);

    }
}
