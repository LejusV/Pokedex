using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grovyle Species to store common natural stats of all Grovyles
	#region GrovyleSpecies
	public class GrovyleSpecies : PokemonSpecies
	{
#nullable enable
		private static GrovyleSpecies? _instance = null;
#nullable restore
        public static GrovyleSpecies Instance => _instance ?? (_instance = new GrovyleSpecies());

		#region GrovyleSpecies Constructor
		public GrovyleSpecies() : base(
			253,
			"Grovyle",
			Grass.Instance,
			0.9,
			21.6,
			new PokemonStats(
				50, // HPs
				65, 45, // Attack & Defense
				85, 65, // Spacial Attack & Defense
				95 // Speed
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
				"Pound",
				"Mega-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Bullet-Seed",
				"Aerial-Ace",
				"Leaf-Blade",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Drain-Punch",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}