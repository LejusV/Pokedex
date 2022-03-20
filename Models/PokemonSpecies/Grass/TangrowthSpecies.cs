using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tangrowth Species to store common natural stats of all Tangrowths
	#region TangrowthSpecies
	public class TangrowthSpecies : PokemonSpecies
	{
#nullable enable
		private static TangrowthSpecies? _instance = null;
#nullable restore
        public static TangrowthSpecies Instance => _instance ?? (_instance = new TangrowthSpecies());

		#region TangrowthSpecies Constructor
		public TangrowthSpecies() : base(
			465,
			"Tangrowth",
			Grass.Instance,
			2.0,
			128.6,
			new PokemonStats(
				100, // HPs
				100, 125, // Attack & Defense
				110, 50, // Spacial Attack & Defense
				50 // Speed
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
				"Cut",
				"Bind",
				"Slam",
				"Vine-Whip",
				"Headbutt",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Constrict",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Tickle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Block",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Wring-Out",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Bulldoze",
				"Grassy-Terrain",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}