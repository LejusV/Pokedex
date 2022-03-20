using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tapu-Bulu Species to store common natural stats of all Tapu-Bulus
	#region Tapu-BuluSpecies
	public class TapuBuluSpecies : PokemonSpecies
	{
#nullable enable
		private static TapuBuluSpecies? _instance = null;
#nullable restore
        public static TapuBuluSpecies Instance => _instance ?? (_instance = new TapuBuluSpecies());

		#region Tapu-BuluSpecies Constructor
		public TapuBuluSpecies() : base(
			787,
			"Tapu-Bulu",
			Grass.Instance, Fairy.Instance,
			1.9,
			45.5,
			new PokemonStats(
				70, // HPs
				130, 115, // Attack & Defense
				85, 95, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Whirlwind",
				"Horn-Attack",
				"Roar",
				"Disable",
				"Hyper-Beam",
				"Leech-Seed",
				"Solar-Beam",
				"Toxic",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Skull-Bash",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Megahorn",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Bulk-Up",
				"Calm-Mind",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Horn-Leech",
				"Snarl",
				"Rototiller",
				"Grassy-Terrain",
				"Confide",
				"Dazzling-Gleam",
				"Leafage",
				"Smart-Strike",
				"Brutal-Swing",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion
}