using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Finneon Species to store common natural stats of all Finneons
	#region FinneonSpecies
	public class FinneonSpecies : PokemonSpecies
	{
#nullable enable
		private static FinneonSpecies? _instance = null;
#nullable restore
        public static FinneonSpecies Instance => _instance ?? (_instance = new FinneonSpecies());

		#region FinneonSpecies Constructor
		public FinneonSpecies() : base(
			456,
			"Finneon",
			Water.Instance,
			0.4,
			7.0,
			new PokemonStats(
				49, // HPs
				49, 56, // Attack & Defense
				49, 61, // Spacial Attack & Defense
				66 // Speed
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
				"Gust",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Aurora-Beam",
				"Toxic",
				"Agility",
				"Double-Team",
				"Confuse-Ray",
				"Waterfall",
				"Swift",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Dive",
				"Air-Cutter",
				"Silver-Wind",
				"Tickle",
				"Signal-Beam",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Aqua-Ring",
				"Aqua-Tail",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Soak",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}