# Pokemon-Go-Rocket-API

Features
```
#PTC Login / Google
#Get Map Objects and Inventory
#Search for gyms/pokestops/spawns
#Farm pokestops
#Farm all pokemons in neighbourhood
#Evolve pokemons
#Transfer pokemons
#Auto Updates
```
Setup
```
#Go to PokemonGo\RocketAPI\Console\App.config -> Edit the Settings you like -> Build and Run (CTRL+F5)

Pokemon transfer types that you can set in app.config
cp - transfers all pokemon below the CP threshold in the app.config, EXCEPT for those types specified in program.cs
leaveStrongest - transfers all but the highest CP pokemon of each type SPECIFIED IN program.cs (those that aren't specified are untouched)
duplicate - same as above but for all pokemon (no need to specify type)
all - transfers all pokemon