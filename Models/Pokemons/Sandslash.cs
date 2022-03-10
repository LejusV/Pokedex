using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sandslash Species to store common natural stats of all Sandslashs
	#region SpeciesSandslash
	public class SpeciesSandslash : PokemonSpecies
	{
#nullable enable
		private static SpeciesSandslash? _instance = null;
#nullable restore
        public static SpeciesSandslash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSandslash();
                }
                return _instance;
            }
        }

		#region SpeciesSandslash Constructor
		public SpeciesSandslash() : base(
			"Sandslash",
			1.0,
			29.5,
			75, // HPs
			100, 110, // Attack & Defense
			45, 55, // Special Attack & Defense
			65		
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Dynamic-Punch",
				"Rapid-Spin",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sandslash PokemonInstance Class
	#region Sandslash
	public class SandslashInstance : PokemonInstance
	{
		#region Sandslash Constructors
		/// <summary>
		/// Sandslash Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SandslashInstance(string nickname, int level)
		: base(
				28,
				SpeciesSandslash.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandslash Builder only waiting for a Level
		/// </summary>
		public SandslashInstance(int level)
		: base(
				28,
				SpeciesSandslash.Instance, // PokemonInstance Species
				"Sandslash", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandslash Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sandslash() : base(
			28,
			SpeciesSandslash.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}