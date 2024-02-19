﻿using Entities;

namespace RepositoryContracts
{
    /// <summary>
    /// Represents data access logic for managing Person entity
    /// </summary>
    public interface ICountriesRepository
    {
        /// <summary>
        /// Adds a new country object to the data store
        /// </summary>
        /// <param name="country"></param>
        /// <returns>Returns the country object after adding it to the data store</returns>
        Task<Country> AddCountry(Country country);

        /// <summary>
        /// Returns all countries in the data store
        /// </summary>
        /// <returns></returns>
        Task<List<Country>> GetAllCountries();

        /// <summary>
        /// Returns a country objrct based on the given country id
        /// </summary>
        /// <param name="countryID">CountryID to search</param>
        /// <returns>Matching country or null</returns>
        Task<Country?> GetCountryByCountryID(Guid countryID);

        /// <summary>
        /// returns a country object on the given country name
        /// </summary>
        /// <param name="coutryName">Country name to searach</param>
        /// <returns>Matching country or null</returns>
        Task<Country?> GetCountryByCountryName(string coutryName);
    }
}
