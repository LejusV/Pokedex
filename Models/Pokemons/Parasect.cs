using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Parasect Species to store common natural stats of all Parasects
	#region SpeciesParasect
	public class SpeciesParasect : PokemonSpecies
	{
#nullable enable
		private static SpeciesParasect? _instance = null;
#nullable restore
        public static SpeciesParasect Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesParasect();
                }
                return _instance;
            }
        }

		#region SpeciesParasect Constructor
		public SpeciesParasect() : base(
			47,
			"Parasect",
			1.0,
			29.5,
			60, // HPs
			95, 80, // Attack & Defense
			60, 80, // Special Attack & Defense
			30		
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"String-Shot",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Skull-Bash",
				"Leech-Life",
				"Spore",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Aromatherapy",
				"Bullet-Seed",
				"Aerial-Ace",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Cross-Poison",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Rage-Powder",
				"After-You",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Parasect PokemonInstance Class
	#region Parasect
	public class ParasectInstance : PokemonInstance
	{
		#region Parasect Constructors
		/// <summary>
		/// Parasect Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ParasectInstance(string nickname, int level)
		: base(
				SpeciesParasect.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Parasect Builder only waiting for a Level
		/// </summary>
		public ParasectInstance(int level)
		: base(
				SpeciesParasect.Instance, // PokemonInstance Species
				"Parasect", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Parasect Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ParasectInstance() : base(
			SpeciesParasect.Instance, // PokemonInstance Species
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}