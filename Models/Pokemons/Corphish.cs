using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Corphish Species to store common natural stats of all Corphishs
	#region SpeciesCorphish
	public class SpeciesCorphish : PokemonSpecies
	{
#nullable enable
		private static SpeciesCorphish? _instance = null;
#nullable restore
        public static SpeciesCorphish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCorphish();
                }
                return _instance;
            }
        }

		#region SpeciesCorphish Constructor
		public SpeciesCorphish() : base(
			"Corphish",
			0.6,
			11.5,
			43, // HPs
			80, 65, // Attack & Defense
			50, 35, // Special Attack & Defense
			35		
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
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Bubble",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
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
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Dance",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Trump-Card",
				"Night-Slash",
				"X-Scissor",
				"Switcheroo",
				"Captivate",
				"Aqua-Jet",
				"Double-Hit",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Corphish PokemonInstance Class
	#region Corphish
	public class CorphishInstance : PokemonInstance
	{
		#region Corphish Constructors
		/// <summary>
		/// Corphish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CorphishInstance(string nickname, int level)
		: base(
				341,
				SpeciesCorphish.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corphish Builder only waiting for a Level
		/// </summary>
		public CorphishInstance(int level)
		: base(
				341,
				SpeciesCorphish.Instance, // PokemonInstance Species
				"Corphish", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corphish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Corphish() : base(
			341,
			SpeciesCorphish.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}