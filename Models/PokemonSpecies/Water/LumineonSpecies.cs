using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lumineon Species to store common natural stats of all Lumineons
	#region LumineonSpecies
	public class LumineonSpecies : PokemonSpecies
	{
#nullable enable
		private static LumineonSpecies? _instance = null;
#nullable restore
        public static LumineonSpecies Instance => _instance ?? (_instance = new LumineonSpecies());

		#region LumineonSpecies Constructor
		public LumineonSpecies() : base(
			457,
			"Lumineon",
			Water.Instance,
			1.2,
			24.0,
			new PokemonStats(
				69, // HPs
				69, 76, // Attack & Defense
				69, 86, // Spacial Attack & Defense
				91 // Speed
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
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
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
				"Secret-Power",
				"Dive",
				"Air-Cutter",
				"Silver-Wind",
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
				"Giga-Impact",
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