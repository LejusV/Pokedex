using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nuzleaf Species to store common natural stats of all Nuzleafs
	#region NuzleafSpecies
	public class NuzleafSpecies : PokemonSpecies
	{
#nullable enable
		private static NuzleafSpecies? _instance = null;
#nullable restore
        public static NuzleafSpecies Instance => _instance ?? (_instance = new NuzleafSpecies());

		#region NuzleafSpecies Constructor
		public NuzleafSpecies() : base(
			274,
			"Nuzleaf",
			Grass.Instance, Dark.Instance,
			1.0,
			28.0,
			new PokemonStats(
				70, // HPs
				70, 40, // Attack & Defense
				60, 40, // Spacial Attack & Defense
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
				"Pound",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
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
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Extrasensory",
				"Bullet-Seed",
				"Leaf-Blade",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Worry-Seed",
				"Dark-Pulse",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}