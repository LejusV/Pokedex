using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Exeggcute Species to store common natural stats of all Exeggcutes
	#region SpeciesExeggcute
	public class SpeciesExeggcute : PokemonSpecies
	{
#nullable enable
		private static SpeciesExeggcute? _instance = null;
#nullable restore
        public static SpeciesExeggcute Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesExeggcute();
                }
                return _instance;
            }
        }

		#region SpeciesExeggcute Constructor
		public SpeciesExeggcute() : base(
			102,
			"Exeggcute",
			0.4,
			2.5,
			60, // HPs
			40, 80, // Attack & Defense
			60, 45, // Special Attack & Defense
			40		
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
				"Swords-Dance",
				"Take-Down",
				"Double-Edge",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Egg-Bomb",
				"Dream-Eater",
				"Barrage",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Skill-Swap",
				"Secret-Power",
				"Extrasensory",
				"Bullet-Seed",
				"Block",
				"Gravity",
				"Natural-Gift",
				"Lucky-Chant",
				"Power-Swap",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Trick-Room",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Telekinesis",
				"Round",
				"Bestow",
				"Grassy-Terrain",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Exeggcute PokemonInstance Class
	#region Exeggcute
	public class ExeggcuteInstance : PokemonInstance
	{
		#region Exeggcute Constructors
		/// <summary>
		/// Exeggcute Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ExeggcuteInstance(string nickname, int level)
		: base(
				SpeciesExeggcute.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggcute Builder only waiting for a Level
		/// </summary>
		public ExeggcuteInstance(int level)
		: base(
				SpeciesExeggcute.Instance, // PokemonInstance Species
				"Exeggcute", level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggcute Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ExeggcuteInstance() : base(
			SpeciesExeggcute.Instance, // PokemonInstance Species
			Grass.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}