using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Whimsicott Species to store common natural stats of all Whimsicotts
	#region WhimsicottSpecies
	public class WhimsicottSpecies : PokemonSpecies
	{
#nullable enable
		private static WhimsicottSpecies? _instance = null;
#nullable restore
        public static WhimsicottSpecies Instance => _instance ?? (_instance = new WhimsicottSpecies());

		#region WhimsicottSpecies Constructor
		public WhimsicottSpecies() : base(
			547,
			"Whimsicott",
			Grass.Instance, Fairy.Instance,
			0.7,
			6.6,
			new PokemonStats(
				60, // HPs
				67, 85, // Attack & Defense
				77, 75, // Spacial Attack & Defense
				116 // Speed
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
				"Gust",
				"Hyper-Beam",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Covet",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Grass-Knot",
				"Round",
				"Hurricane",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}