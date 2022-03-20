using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Castform Species to store common natural stats of all Castforms
	#region CastformSpecies
	public class CastformSpecies : PokemonSpecies
	{
#nullable enable
		private static CastformSpecies? _instance = null;
#nullable restore
        public static CastformSpecies Instance => _instance ?? (_instance = new CastformSpecies());

		#region CastformSpecies Constructor
		public CastformSpecies() : base(
			351,
			"Castform",
			Normal.Instance,
			0.3,
			0.8,
			new PokemonStats(
				70, // HPs
				70, 70, // Attack & Defense
				70, 70, // Spacial Attack & Defense
				70 // Speed
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Disable",
				"Ember",
				"Flamethrower",
				"Water-Gun",
				"Hydro-Pump",
				"Ice-Beam",
				"Blizzard",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Hail",
				"Facade",
				"Secret-Power",
				"Weather-Ball",
				"Cosmic-Power",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Tailwind",
				"Lucky-Chant",
				"Guard-Swap",
				"Last-Resort",
				"Energy-Ball",
				"Avalanche",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Clear-Smog",
				"Scald",
				"Hex",
				"Incinerate",
				"Reflect-Type",
				"Retaliate",
				"Work-Up",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}