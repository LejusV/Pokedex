using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Serperior Species to store common natural stats of all Serperiors
	#region SerperiorSpecies
	public class SerperiorSpecies : PokemonSpecies
	{
#nullable enable
		private static SerperiorSpecies? _instance = null;
#nullable restore
        public static SerperiorSpecies Instance => _instance ?? (_instance = new SerperiorSpecies());

		#region SerperiorSpecies Constructor
		public SerperiorSpecies() : base(
			497,
			"Serperior",
			Grass.Instance,
			3.3,
			63.0,
			new PokemonStats(
				75, // HPs
				75, 95, // Attack & Defense
				75, 95, // Spacial Attack & Defense
				113 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Frenzy-Plant",
				"Calm-Mind",
				"Leaf-Blade",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Aqua-Tail",
				"Seed-Bomb",
				"Dragon-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Grass-Knot",
				"Coil",
				"Round",
				"Grass-Pledge",
				"Dragon-Tail",
				"Work-Up",
				"Leaf-Tornado",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}