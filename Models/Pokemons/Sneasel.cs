using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sneasel Species to store common natural stats of all Sneasels
	#region SpeciesSneasel
	public class SpeciesSneasel : PokemonSpecies
	{
#nullable enable
		private static SpeciesSneasel? _instance = null;
#nullable restore
        public static SpeciesSneasel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSneasel();
                }
                return _instance;
            }
        }

		#region SpeciesSneasel Constructor
		public SpeciesSneasel() : base(
			"Sneasel",
			0.9,
			28.0,
			55, // HPs
			95, 55, // Attack & Defense
			35, 75, // Special Attack & Defense
			115		
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
				"Ice-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Beat-Up",
				"Fake-Out",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Assist",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Crush-Claw",
				"Aerial-Ace",
				"Calm-Mind",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Embargo",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Avalanche",
				"Ice-Shard",
				"Shadow-Claw",
				"Captivate",
				"Double-Hit",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Snarl",
				"Icicle-Crash",
				"Confide",
				"Power-Up-Punch",
				"Throat-Chop"
			};
		}
		#endregion
	}
	#endregion

	//Sneasel PokemonInstance Class
	#region Sneasel
	public class SneaselInstance : PokemonInstance
	{
		#region Sneasel Constructors
		/// <summary>
		/// Sneasel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SneaselInstance(string nickname, int level)
		: base(
				215,
				SpeciesSneasel.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sneasel Builder only waiting for a Level
		/// </summary>
		public SneaselInstance(int level)
		: base(
				215,
				SpeciesSneasel.Instance, // PokemonInstance Species
				"Sneasel", level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sneasel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sneasel() : base(
			215,
			SpeciesSneasel.Instance, // PokemonInstance Species
			Dark.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}