using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Paras Species to store common natural stats of all Parass
	#region SpeciesParas
	public class SpeciesParas : PokemonSpecies
	{
#nullable enable
		private static SpeciesParas? _instance = null;
#nullable restore
        public static SpeciesParas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesParas();
                }
                return _instance;
            }
        }

		#region SpeciesParas Constructor
		public SpeciesParas() : base(
			"Paras",
			0.3,
			5.4,
			35, // HPs
			70, 55, // Attack & Defense
			45, 55, // Special Attack & Defense
			25		
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
				"Psybeam",
				"Counter",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
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
				"Flail",
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
				"Pursuit",
				"Sweet-Scent",
				"Metal-Claw",
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
				"Cross-Poison",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Hone-Claws",
				"Wide-Guard",
				"Venoshock",
				"Rage-Powder",
				"After-You",
				"Round",
				"Struggle-Bug",
				"Rototiller",
				"Fell-Stinger",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Paras PokemonInstance Class
	#region Paras
	public class ParasInstance : PokemonInstance
	{
		#region Paras Constructors
		/// <summary>
		/// Paras Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ParasInstance(string nickname, int level)
		: base(
				46,
				SpeciesParas.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Paras Builder only waiting for a Level
		/// </summary>
		public ParasInstance(int level)
		: base(
				46,
				SpeciesParas.Instance, // PokemonInstance Species
				"Paras", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Paras Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Paras() : base(
			46,
			SpeciesParas.Instance, // PokemonInstance Species
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}