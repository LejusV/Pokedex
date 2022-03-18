using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Krabby Species to store common natural stats of all Krabbys
	#region SpeciesKrabby
	public class SpeciesKrabby : PokemonSpecies
	{
#nullable enable
		private static SpeciesKrabby? _instance = null;
#nullable restore
        public static SpeciesKrabby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKrabby();
                }
                return _instance;
            }
        }

		#region SpeciesKrabby Constructor
		public SpeciesKrabby() : base(
			98,
			"Krabby",
			0.4,
			6.5,
			30, // HPs
			105, 90, // Attack & Defense
			25, 25, // Special Attack & Defense
			50		
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
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Haze",
				"Bide",
				"Amnesia",
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
				"Tickle",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"X-Scissor",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Ally-Switch",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Krabby PokemonInstance Class
	#region Krabby
	public class KrabbyInstance : PokemonInstance
	{
		#region Krabby Constructors
		/// <summary>
		/// Krabby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KrabbyInstance(string nickname, int level)
		: base(
				SpeciesKrabby.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krabby Builder only waiting for a Level
		/// </summary>
		public KrabbyInstance(int level)
		: base(
				SpeciesKrabby.Instance, // PokemonInstance Species
				"Krabby", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krabby Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KrabbyInstance() : base(
			SpeciesKrabby.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}