using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Treecko Species to store common natural stats of all Treeckos
	#region TreeckoSpecies
	public class TreeckoSpecies : PokemonSpecies
	{
#nullable enable
		private static TreeckoSpecies? _instance = null;
#nullable restore
        public static TreeckoSpecies Instance => _instance ?? (_instance = new TreeckoSpecies());

		#region TreeckoSpecies Constructor
		public TreeckoSpecies() : base(
			252,
			"Treecko",
			Grass.Instance,
			0.5,
			5.0,
			new PokemonStats(
				40, // HPs
				45, 35, // Attack & Defense
				65, 55, // Spacial Attack & Defense
				70 // Speed
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Double-Kick",
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
				"Leech-Seed",
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
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Pursuit",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Grass-Whistle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Magical-Leaf",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Grassy-Terrain",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}