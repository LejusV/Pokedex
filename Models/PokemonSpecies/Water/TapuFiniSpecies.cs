using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tapu-Fini Species to store common natural stats of all Tapu-Finis
	#region Tapu-FiniSpecies
	public class TapuFiniSpecies : PokemonSpecies
	{
#nullable enable
		private static TapuFiniSpecies? _instance = null;
#nullable restore
        public static TapuFiniSpecies Instance => _instance ?? (_instance = new TapuFiniSpecies());

		#region Tapu-FiniSpecies Constructor
		public TapuFiniSpecies() : base(
			788,
			"Tapu-Fini",
			Water.Instance, Fairy.Instance,
			1.3,
			21.2,
			new PokemonStats(
				70, // HPs
				75, 115, // Attack & Defense
				95, 130, // Spacial Attack & Defense
				85 // Speed
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
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Waterfall",
				"Substitute",
				"Protect",
				"Swagger",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Refresh",
				"Muddy-Water",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Fling",
				"Aqua-Ring",
				"Giga-Impact",
				"Defog",
				"Grass-Knot",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Smart-Strike",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion
}