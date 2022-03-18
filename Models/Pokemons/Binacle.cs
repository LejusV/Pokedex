using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Binacle Species to store common natural stats of all Binacles
	#region SpeciesBinacle
	public class SpeciesBinacle : PokemonSpecies
	{
#nullable enable
		private static SpeciesBinacle? _instance = null;
#nullable restore
        public static SpeciesBinacle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBinacle();
                }
                return _instance;
            }
        }

		#region SpeciesBinacle Constructor
		public SpeciesBinacle() : base(
			688,
			"Binacle",
			0.5,
			31.0,
			42, // HPs
			52, 67, // Attack & Defense
			39, 56, // Special Attack & Defense
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Clamp",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Tickle",
				"Aerial-Ace",
				"Iron-Defense",
				"Water-Sport",
				"Water-Pulse",
				"Payback",
				"Embargo",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Switcheroo",
				"Shadow-Claw",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Shell-Smash",
				"Bulldoze",
				"Dual-Chop",
				"Razor-Shell",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Binacle PokemonInstance Class
	#region Binacle
	public class BinacleInstance : PokemonInstance
	{
		#region Binacle Constructors
		/// <summary>
		/// Binacle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BinacleInstance(string nickname, int level)
		: base(
				SpeciesBinacle.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Binacle Builder only waiting for a Level
		/// </summary>
		public BinacleInstance(int level)
		: base(
				SpeciesBinacle.Instance, // PokemonInstance Species
				"Binacle", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Binacle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BinacleInstance() : base(
			SpeciesBinacle.Instance, // PokemonInstance Species
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}