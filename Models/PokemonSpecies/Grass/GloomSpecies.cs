using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gloom Species to store common natural stats of all Glooms
	#region GloomSpecies
	public class GloomSpecies : PokemonSpecies
	{
#nullable enable
		private static GloomSpecies? _instance = null;
#nullable restore
        public static GloomSpecies Instance => _instance ?? (_instance = new GloomSpecies());

		#region GloomSpecies Constructor
		public GloomSpecies() : base(
			44,
			"Gloom",
			Grass.Instance, Poison.Instance,
			0.8,
			8.6,
			new PokemonStats(
				60, // HPs
				65, 70, // Attack & Defense
				85, 75, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Petal-Dance",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Fling",
				"Gastro-Acid",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Grassy-Terrain",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}