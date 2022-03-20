using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Snivy Species to store common natural stats of all Snivys
	#region SnivySpecies
	public class SnivySpecies : PokemonSpecies
	{
#nullable enable
		private static SnivySpecies? _instance = null;
#nullable restore
        public static SnivySpecies Instance => _instance ?? (_instance = new SnivySpecies());

		#region SnivySpecies Constructor
		public SnivySpecies() : base(
			495,
			"Snivy",
			Grass.Instance,
			0.6,
			8.1,
			new PokemonStats(
				45, // HPs
				45, 55, // Attack & Defense
				45, 55, // Spacial Attack & Defense
				63 // Speed
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
				"Tackle",
				"Wrap",
				"Leer",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Glare",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pursuit",
				"Sweet-Scent",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Mirror-Coat",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Magical-Leaf",
				"Calm-Mind",
				"Leaf-Blade",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Aqua-Tail",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Coil",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Leaf-Tornado",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}