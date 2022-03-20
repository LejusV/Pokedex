using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Herdier Species to store common natural stats of all Herdiers
	#region HerdierSpecies
	public class HerdierSpecies : PokemonSpecies
	{
#nullable enable
		private static HerdierSpecies? _instance = null;
#nullable restore
        public static HerdierSpecies Instance => _instance ?? (_instance = new HerdierSpecies());

		#region HerdierSpecies Constructor
		public HerdierSpecies() : base(
			507,
			"Herdier",
			Normal.Instance,
			0.9,
			14.7,
			new PokemonStats(
				65, // HPs
				80, 65, // Attack & Defense
				35, 65, // Spacial Attack & Defense
				60 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Tackle",
				"Take-Down",
				"Leer",
				"Bite",
				"Roar",
				"Surf",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Payback",
				"Last-Resort",
				"Giga-Impact",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}