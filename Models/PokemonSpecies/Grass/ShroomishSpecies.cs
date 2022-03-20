using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shroomish Species to store common natural stats of all Shroomishs
	#region ShroomishSpecies
	public class ShroomishSpecies : PokemonSpecies
	{
#nullable enable
		private static ShroomishSpecies? _instance = null;
#nullable restore
        public static ShroomishSpecies Instance => _instance ?? (_instance = new ShroomishSpecies());

		#region ShroomishSpecies Constructor
		public ShroomishSpecies() : base(
			285,
			"Shroomish",
			Grass.Instance,
			0.4,
			4.5,
			new PokemonStats(
				60, // HPs
				40, 60, // Attack & Defense
				40, 60, // Spacial Attack & Defense
				35 // Speed
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Charm",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Snatch",
				"Secret-Power",
				"Fake-Tears",
				"Bullet-Seed",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}