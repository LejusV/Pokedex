using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Garbodor Species to store common natural stats of all Garbodors
	#region GarbodorSpecies
	public class GarbodorSpecies : PokemonSpecies
	{
#nullable enable
		private static GarbodorSpecies? _instance = null;
#nullable restore
        public static GarbodorSpecies Instance => _instance ?? (_instance = new GarbodorSpecies());

		#region GarbodorSpecies Constructor
		public GarbodorSpecies() : base(
			569,
			"Garbodor",
			Poison.Instance,
			1.9,
			107.3,
			new PokemonStats(
				80, // HPs
				95, 82, // Attack & Defense
				60, 82, // Spacial Attack & Defense
				75 // Speed
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
				"Pound",
				"Double-Slap",
				"Body-Slam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Sludge",
				"Amnesia",
				"Poison-Gas",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Stockpile",
				"Swallow",
				"Facade",
				"Recycle",
				"Secret-Power",
				"Payback",
				"Fling",
				"Toxic-Spikes",
				"Rock-Polish",
				"Dark-Pulse",
				"Seed-Bomb",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Gunk-Shot",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Clear-Smog",
				"Belch",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}