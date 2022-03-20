using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shiftry Species to store common natural stats of all Shiftrys
	#region ShiftrySpecies
	public class ShiftrySpecies : PokemonSpecies
	{
#nullable enable
		private static ShiftrySpecies? _instance = null;
#nullable restore
        public static ShiftrySpecies Instance => _instance ?? (_instance = new ShiftrySpecies());

		#region ShiftrySpecies Constructor
		public ShiftrySpecies() : base(
			275,
			"Shiftry",
			Grass.Instance, Dark.Instance,
			1.3,
			59.6,
			new PokemonStats(
				90, // HPs
				100, 60, // Attack & Defense
				90, 60, // Spacial Attack & Defense
				80 // Speed
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
				"Swords-Dance",
				"Cut",
				"Whirlwind",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Silver-Wind",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Natural-Gift",
				"Tailwind",
				"Payback",
				"Embargo",
				"Fling",
				"Worry-Seed",
				"Sucker-Punch",
				"Dark-Pulse",
				"Seed-Bomb",
				"X-Scissor",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Defog",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Leaf-Tornado",
				"Hurricane",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}