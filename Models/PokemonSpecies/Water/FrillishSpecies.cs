using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Frillish Species to store common natural stats of all Frillishs
	#region FrillishSpecies
	public class FrillishSpecies : PokemonSpecies
	{
#nullable enable
		private static FrillishSpecies? _instance = null;
#nullable restore
        public static FrillishSpecies Instance => _instance ?? (_instance = new FrillishSpecies());

		#region FrillishSpecies Constructor
		public FrillishSpecies() : base(
			592,
			"Frillish",
			Water.Instance, Ghost.Instance,
			1.2,
			33.0,
			new PokemonStats(
				55, // HPs
				40, 50, // Attack & Defense
				65, 85, // Spacial Attack & Defense
				40 // Speed
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
				"Bind",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Absorb",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Waterfall",
				"Constrict",
				"Dream-Eater",
				"Bubble",
				"Flash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Secret-Power",
				"Dive",
				"Water-Spout",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Wring-Out",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Ominous-Wind",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Hex",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}