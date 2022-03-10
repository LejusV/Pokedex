using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slugma Species to store common natural stats of all Slugmas
	#region SpeciesSlugma
	public class SpeciesSlugma : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlugma? _instance = null;
#nullable restore
        public static SpeciesSlugma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlugma();
                }
                return _instance;
            }
        }

		#region SpeciesSlugma Constructor
		public SpeciesSlugma() : base(
			"Slugma",
			0.7,
			35.0,
			40, // HPs
			40, 40, // Attack & Defense
			70, 40, // Special Attack & Defense
			20		
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
				"Body-Slam",
				"Double-Edge",
				"Ember",
				"Flamethrower",
				"Rock-Throw",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Harden",
				"Smokescreen",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Smog",
				"Fire-Blast",
				"Amnesia",
				"Acid-Armor",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Heat-Wave",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Natural-Gift",
				"Guard-Swap",
				"Earth-Power",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Inferno",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Slugma PokemonInstance Class
	#region Slugma
	public class SlugmaInstance : PokemonInstance
	{
		#region Slugma Constructors
		/// <summary>
		/// Slugma Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlugmaInstance(string nickname, int level)
		: base(
				218,
				SpeciesSlugma.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slugma Builder only waiting for a Level
		/// </summary>
		public SlugmaInstance(int level)
		: base(
				218,
				SpeciesSlugma.Instance, // PokemonInstance Species
				"Slugma", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slugma Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Slugma() : base(
			218,
			SpeciesSlugma.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}