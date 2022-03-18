using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shiftry Species to store common natural stats of all Shiftrys
	#region SpeciesShiftry
	public class SpeciesShiftry : PokemonSpecies
	{
#nullable enable
		private static SpeciesShiftry? _instance = null;
#nullable restore
        public static SpeciesShiftry Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShiftry();
                }
                return _instance;
            }
        }

		#region SpeciesShiftry Constructor
		public SpeciesShiftry() : base(
			275,
			"Shiftry",
			1.3,
			59.6,
			90, // HPs
			100, 60, // Attack & Defense
			90, 60, // Special Attack & Defense
			80		
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

	//Shiftry PokemonInstance Class
	#region Shiftry
	public class ShiftryInstance : PokemonInstance
	{
		#region Shiftry Constructors
		/// <summary>
		/// Shiftry Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShiftryInstance(string nickname, int level)
		: base(
				SpeciesShiftry.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiftry Builder only waiting for a Level
		/// </summary>
		public ShiftryInstance(int level)
		: base(
				SpeciesShiftry.Instance, // PokemonInstance Species
				"Shiftry", level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiftry Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ShiftryInstance() : base(
			SpeciesShiftry.Instance, // PokemonInstance Species
			Grass.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}