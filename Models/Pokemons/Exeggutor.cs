using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Exeggutor Species to store common natural stats of all Exeggutors
	#region SpeciesExeggutor
	public class SpeciesExeggutor : PokemonSpecies
	{
#nullable enable
		private static SpeciesExeggutor? _instance = null;
#nullable restore
        public static SpeciesExeggutor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesExeggutor();
                }
                return _instance;
            }
        }

		#region SpeciesExeggutor Constructor
		public SpeciesExeggutor() : base(
			"Exeggutor",
			2.0,
			120.0,
			95, // HPs
			95, 85, // Attack & Defense
			125, 75, // Special Attack & Defense
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
				"Swords-Dance",
				"Stomp",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Mega-Drain",
				"Solar-Beam",
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
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Facade",
				"Nature-Power",
				"Skill-Swap",
				"Secret-Power",
				"Bullet-Seed",
				"Block",
				"Gravity",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Wood-Hammer",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Exeggutor PokemonInstance Class
	#region Exeggutor
	public class ExeggutorInstance : PokemonInstance
	{
		#region Exeggutor Constructors
		/// <summary>
		/// Exeggutor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ExeggutorInstance(string nickname, int level)
		: base(
				103,
				SpeciesExeggutor.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggutor Builder only waiting for a Level
		/// </summary>
		public ExeggutorInstance(int level)
		: base(
				103,
				SpeciesExeggutor.Instance, // PokemonInstance Species
				"Exeggutor", level,
				Grass.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggutor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Exeggutor() : base(
			103,
			SpeciesExeggutor.Instance, // PokemonInstance Species
			Grass.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}