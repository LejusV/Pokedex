using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nuzleaf Species to store common natural stats of all Nuzleafs
	#region SpeciesNuzleaf
	public class SpeciesNuzleaf : PokemonSpecies
	{
#nullable enable
		private static SpeciesNuzleaf? _instance = null;
#nullable restore
        public static SpeciesNuzleaf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNuzleaf();
                }
                return _instance;
            }
        }

		#region SpeciesNuzleaf Constructor
		public SpeciesNuzleaf() : base(
			"Nuzleaf",
			1.0,
			28.0,
			70, // HPs
			70, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			60		
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

	//Nuzleaf PokemonInstance Class
	#region Nuzleaf
	public class NuzleafInstance : PokemonInstance
	{
		#region Nuzleaf Constructors
		/// <summary>
		/// Nuzleaf Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NuzleafInstance(string nickname, int level)
		: base(
				274,
				SpeciesNuzleaf.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nuzleaf Builder only waiting for a Level
		/// </summary>
		public NuzleafInstance(int level)
		: base(
				274,
				SpeciesNuzleaf.Instance, // PokemonInstance Species
				"Nuzleaf", level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nuzleaf Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Nuzleaf() : base(
			274,
			SpeciesNuzleaf.Instance, // PokemonInstance Species
			Grass.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}