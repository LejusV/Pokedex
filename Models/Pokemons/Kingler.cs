using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kingler Species to store common natural stats of all Kinglers
	#region SpeciesKingler
	public class SpeciesKingler : PokemonSpecies
	{
#nullable enable
		private static SpeciesKingler? _instance = null;
#nullable restore
        public static SpeciesKingler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKingler();
                }
                return _instance;
            }
        }

		#region SpeciesKingler Constructor
		public SpeciesKingler() : base(
			99,
			"Kingler",
			1.3,
			60.0,
			55, // HPs
			130, 115, // Attack & Defense
			50, 50, // Special Attack & Defense
			75		
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
				"Vice-Grip",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Stomp",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Bide",
				"Bubble",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"X-Scissor",
				"Giga-Impact",
				"Captivate",
				"Hone-Claws",
				"Wide-Guard",
				"Round",
				"Scald",
				"Quash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Kingler PokemonInstance Class
	#region Kingler
	public class KinglerInstance : PokemonInstance
	{
		#region Kingler Constructors
		/// <summary>
		/// Kingler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KinglerInstance(string nickname, int level)
		: base(
				SpeciesKingler.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingler Builder only waiting for a Level
		/// </summary>
		public KinglerInstance(int level)
		: base(
				SpeciesKingler.Instance, // PokemonInstance Species
				"Kingler", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingler Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KinglerInstance() : base(
			SpeciesKingler.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}