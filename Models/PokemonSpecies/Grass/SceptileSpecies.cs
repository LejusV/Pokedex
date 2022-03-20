using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sceptile Species to store common natural stats of all Sceptiles
	#region SceptileSpecies
	public class SceptileSpecies : PokemonSpecies
	{
#nullable enable
		private static SceptileSpecies? _instance = null;
#nullable restore
        public static SceptileSpecies Instance => _instance ?? (_instance = new SceptileSpecies());

		#region SceptileSpecies Constructor
		public SceptileSpecies() : base(
			254,
			"Sceptile",
			Grass.Instance,
			1.7,
			52.2,
			new PokemonStats(
				70, // HPs
				85, 65, // Attack & Defense
				105, 85, // Spacial Attack & Defense
				120 // Speed
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
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Earthquake",
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
				"Outrage",
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
				"Dragon-Claw",
				"Frenzy-Plant",
				"Leaf-Blade",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Night-Slash",
				"Seed-Bomb",
				"X-Scissor",
				"Dragon-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Rock-Climb",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}