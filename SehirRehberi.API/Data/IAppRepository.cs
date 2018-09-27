using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        List<City> GetCities();
        City GetCityById(int cityId);
        Photo GetPhoto(int id);
        Photo GetPhotoByCityId(int cityId);
        bool SaveAll();
    }
}
