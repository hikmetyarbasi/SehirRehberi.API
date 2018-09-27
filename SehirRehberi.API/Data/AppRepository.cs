using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _dataContext;

        public AppRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _dataContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dataContext.Remove(entity);
        }

        public List<City> GetCities()
        {
            return _dataContext.Cities.Include(p => p.Photos).ToList();
        }

        public City GetCityById(int cityId)
        {
            return _dataContext.Cities.Include(p => p.Photos).FirstOrDefault(s => s.Id == cityId);
        }

        public Photo GetPhoto(int id)
        {
            return _dataContext.Photos.FirstOrDefault(s => s.Id == id);
        }

        public Photo GetPhotoByCityId(int cityId)
        {
            return _dataContext.Photos.Include(p => p.City).FirstOrDefault(s => s.CityId == cityId);
        }

        public bool SaveAll()
        {
            return _dataContext.SaveChanges() > 0;
        }
    }
}
