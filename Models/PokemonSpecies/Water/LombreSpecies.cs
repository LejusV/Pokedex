using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lombre Species to store common natural stats of all Lombres
	#region LombreSpecies
	public class LombreSpecies : PokemonSpecies
	{
#nullable enable
		private static LombreSpecies? _instance = null;
#nullable restore
        public static LombreSpecies Instance => _instance ?? (_instance = new LombreSpecies());

		#region LombreSpecies Constructor
		public LombreSpecies() : base(
			271,
			"Lombre",
			Water.Instance, Grass.Instance,
			1.2,
			32.5,
			new PokemonStats(
				60, // HPs
				50, 50, // Attack & Defense
				60, 70, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Strength",
				"Absorb",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Uproar",
				"Hail",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Astonish",
				"Bullet-Seed",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}