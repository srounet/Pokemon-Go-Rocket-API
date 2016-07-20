#region

using PokemonGo.RocketAPI.Enums;

#endregion

namespace PokemonGo.RocketAPI
{
    public interface ISettings
    {
        AuthType AuthType { get; }
        double DefaultLatitude { get; }
        double DefaultLongitude { get; }
        string GoogleRefreshToken { get; set; }
        string PtcPassword { get; }
        string PtcUsername { get; }
        bool TransferAllButStrongestUnwantedPokemon { get; set; }
        bool EvolveAllGivenPokemons { get; set; }
        bool TransferAllGivenPokemons { get; set; }
        bool TransferDuplicatePokemon { get; set; }
    }
}