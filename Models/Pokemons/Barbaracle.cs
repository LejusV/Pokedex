using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Barbaracle Species to store common natural stats of all Barbaracles
	#region SpeciesBarbaracle
	public class SpeciesBarbaracle : PokemonSpecies
	{
#nullable enable
		private static SpeciesBarbaracle? _instance = null;
#nullable restore
        public static SpeciesBarbaracle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBarbaracle();
                }
                return _instance;
            }
        }

		#region SpeciesBarbaracle Constructor
		public SpeciesBarbaracle() : base(
			689,
			"Barbaracle",
			1.3,
			96.0,
			72, // HPs
			105, 115, // Attack & Defense
			54, 86, // Special Attack & Defense
			68		
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
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Clamp",
				"Skull-Bash",
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
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Water-Pulse",
				"Payback",
				"Embargo",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
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
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Barbaracle PokemonInstance Class
	#region Barbaracle
	public class BarbaracleInstance : PokemonInstance
	{
		#region Barbaracle Constructors
		/// <summary>
		/// Barbaracle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BarbaracleInstance(string nickname, int level)
		: base(
				SpeciesBarbaracle.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barbaracle Builder only waiting for a Level
		/// </summary>
		public BarbaracleInstance(int level)
		: base(
				SpeciesBarbaracle.Instance, // PokemonInstance Species
				"Barbaracle", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barbaracle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BarbaracleInstance() : base(
			SpeciesBarbaracle.Instance, // PokemonInstance Species
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}