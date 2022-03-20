using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tangela Species to store common natural stats of all Tangelas
	#region TangelaSpecies
	public class TangelaSpecies : PokemonSpecies
	{
#nullable enable
		private static TangelaSpecies? _instance = null;
#nullable restore
        public static TangelaSpecies Instance => _instance ?? (_instance = new TangelaSpecies());

		#region TangelaSpecies Constructor
		public TangelaSpecies() : base(
			114,
			"Tangela",
			Grass.Instance,
			1.0,
			35.0,
			new PokemonStats(
				65, // HPs
				55, 115, // Attack & Defense
				100, 40, // Spacial Attack & Defense
				60 // Speed
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Confusion",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Skull-Bash",
				"Constrict",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Tickle",
				"Bullet-Seed",
				"Shock-Wave",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Wring-Out",
				"Power-Swap",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Rage-Powder",
				"Round",
				"Grassy-Terrain",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}