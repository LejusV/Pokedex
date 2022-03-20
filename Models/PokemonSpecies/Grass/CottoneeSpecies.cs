using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cottonee Species to store common natural stats of all Cottonees
	#region CottoneeSpecies
	public class CottoneeSpecies : PokemonSpecies
	{
#nullable enable
		private static CottoneeSpecies? _instance = null;
#nullable restore
        public static CottoneeSpecies Instance => _instance ?? (_instance = new CottoneeSpecies());

		#region CottoneeSpecies Constructor
		public CottoneeSpecies() : base(
			546,
			"Cottonee",
			Grass.Instance, Fairy.Instance,
			0.3,
			0.6,
			new PokemonStats(
				40, // HPs
				27, 60, // Attack & Defense
				37, 50, // Spacial Attack & Defense
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
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Toxic",
				"Double-Team",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Giga-Drain",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Hidden-Power",
				"Sunny-Day",
				"Beat-Up",
				"Memento",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Fake-Tears",
				"Grass-Whistle",
				"Tickle",
				"Covet",
				"Natural-Gift",
				"Tailwind",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Switcheroo",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Cotton-Guard",
				"Misty-Terrain",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}