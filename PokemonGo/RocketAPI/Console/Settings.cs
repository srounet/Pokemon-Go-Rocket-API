#region

using System.Configuration;
using System.Globalization;
using System.Runtime.CompilerServices;
using PokemonGo.RocketAPI.Enums;

#endregion

namespace PokemonGo.RocketAPI.Console
{
    public class Settings : ISettings
    {
        /// <summary>
        ///     CHANGE THESE SETTINGS AS YOU LIKE
        /// </summary>
        public bool TransferAllGivenPokemons { get; set; } = false; //HANDLE WITH CARE - Transfers EVERYTHING

        public bool EvolveAllGivenPokemons { get; set; } = false; // Evolves everything!

        public bool TransferAllButStrongestUnwantedPokemon { get; set; } = false; // Transfers those crappy Pokemons

        public bool TransferDuplicatePokemon { get; set; } = false; // Transfers Pokemon that you have duplicate

        public AuthType AuthType => AuthType.Google; // what authentication method you want
        public string PtcUsername => GetSetting() != string.Empty ? GetSetting() : "username";
        public string PtcPassword => GetSetting() != string.Empty ? GetSetting() : "password";

        public double DefaultLatitude => GetSetting() != string.Empty ? double.Parse(GetSetting(), CultureInfo.InvariantCulture) : 51.22640;

        //Default Amsterdam Central Station
        public double DefaultLongitude => GetSetting() != string.Empty ? double.Parse(GetSetting(), CultureInfo.InvariantCulture) : 6.77874;

        //Default Amsterdam Central Station

        // LEAVE EVERYTHING ALONE


        public string GoogleRefreshToken
        {
            get { return GetSetting() != string.Empty ? GetSetting() : string.Empty; }
            set { SetSetting(value); }
        }

        private string GetSetting([CallerMemberName] string key = null)
        {
            return ConfigurationManager.AppSettings[key];
        }

        private void SetSetting(string value, [CallerMemberName] string key = null)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (key != null) configFile.AppSettings.Settings[key].Value = value;
            configFile.Save();
        }
    }
}