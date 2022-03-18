using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Crawdaunt Species to store common natural stats of all Crawdaunts
	#region SpeciesCrawdaunt
	public class SpeciesCrawdaunt : PokemonSpecies
	{
#nullable enable
		private static SpeciesCrawdaunt? _instance = null;
#nullable restore
        public static SpeciesCrawdaunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCrawdaunt();
                }
                return _instance;
            }
        }

		#region SpeciesCrawdaunt Constructor
		public SpeciesCrawdaunt() : base(
			342,
			"Crawdaunt",
			1.1,
			32.8,
			63, // HPs
			120, 85, // Attack & Defense
			90, 55, // Special Attack & Defense
			55		
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
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Swift",
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
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Avalanche",
				"Captivate",
				"Double-Hit",
				"Hone-Claws",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Retaliate",
				"Razor-Shell",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Crawdaunt PokemonInstance Class
	#region Crawdaunt
	public class CrawdauntInstance : PokemonInstance
	{
		#region Crawdaunt Constructors
		/// <summary>
		/// Crawdaunt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CrawdauntInstance(string nickname, int level)
		: base(
				SpeciesCrawdaunt.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crawdaunt Builder only waiting for a Level
		/// </summary>
		public CrawdauntInstance(int level)
		: base(
				SpeciesCrawdaunt.Instance, // PokemonInstance Species
				"Crawdaunt", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crawdaunt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CrawdauntInstance() : base(
			SpeciesCrawdaunt.Instance, // PokemonInstance Species
			Water.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}