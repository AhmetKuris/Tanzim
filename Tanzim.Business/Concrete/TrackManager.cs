using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzim.Business.Abstract;
using Tanzim.Business.Properties;
using Tanzim.DataAccess.Abstract;
using Tanzim.Entities.Concrete;

namespace Tanzim.Business.Concrete
{
    public class TrackManager:ITrackService
    {
        private ITrackDal _trackDal;
        private int _loggedInUserId;

        public TrackManager(ITrackDal trackDal)
        {
            _trackDal = trackDal;
            _loggedInUserId = Settings.Default.LoggedInUserId;
        }

        public void Add(Track track)
        {
            _trackDal.Add(track);
        }

        public void Delete(Track track)
        {
            _trackDal.Delete(track);
        }

        public void Update(Track track)
        {
            _trackDal.Update(track);
        }

       

    

        //OUTER METHODS
        public List<Track> GetAllTracksOfCurrentUser()
        {
            return GetAllTracksByUserId(_loggedInUserId);
        }

        public List<Track> GetAllTracksOfCurrentUserByCategoryId(int categoryId)
        {
            return GetAllTracksByUserIdAndCategoryId(_loggedInUserId, categoryId);
        }


        public void SubmitTrackAndCategoryId(int categoryId, Track track)
        {
            SubmitTrackByUserIdAndCategoryId(_loggedInUserId, categoryId, track);
        }



        //INNER METHODS
        public List<Track> GetAllTracksByUserId(int userId)
        {
                return _trackDal.GetList(t => t.UserId ==userId).Select(t => new Track
                {
                    Id =t.Id,
                    UserId = userId,
                    CategoryId = t.CategoryId,
                    Name = t.Name,
                    StartTime = t.StartTime,
                    StopTime = t.StopTime

                }).ToList();
        }

        public List<Track> GetAllTracksByUserIdAndCategoryId(int userId, int categoryId)
        {
            return _trackDal.GetList(t => t.UserId == userId && t.CategoryId == categoryId).Select(t => new Track
            {
                Id = t.Id,
                UserId = userId,
                CategoryId = categoryId,
                Name = t.Name,
                StartTime = t.StartTime,
                StopTime = t.StopTime
            }).ToList();
        }

        public List<Track> GetAllTracksByUserIdAndStartTimeDay(int userId, DateTime startTime)
        {
            
            return _trackDal.GetList(t => t.UserId == userId && t.StartTime.ToShortTimeString() == startTime.ToShortDateString()).Select(t => new Track
                {
                    Id = t.Id,
                    UserId = userId,
                    CategoryId = t.CategoryId,
                    Name = t.Name,
                    StartTime =t.StartTime,
                    StopTime = t.StopTime
                })
                .ToList();
        }

        public List<Track> GetAllTracksBetweenFromTimeToTimeByUserId(int userId, DateTime fromTime, DateTime toTime)
        {
            return _trackDal.GetList(t => t.StartTime.Date >= fromTime.Date && t.StartTime.Date <= toTime.Date).Select(
                t => new Track
                {
                    Id = t.Id,
                    UserId = userId,
                    CategoryId = t.CategoryId,
                    Name = t.Name,
                    StartTime = t.StartTime,
                    StopTime = t.StopTime

                }).ToList();
        }

        public void SubmitTrackByUserIdAndCategoryId(int userId, int categoryId, Track track)
        {
            _trackDal.Add(new Track
            {
                UserId = userId,
                CategoryId = categoryId,
                Name = track.Name,
                StartTime = track.StartTime,
                StopTime = track.StopTime
            });
        }
    }

  
}
