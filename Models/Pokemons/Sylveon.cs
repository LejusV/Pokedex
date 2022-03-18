using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sylveon Species to store common natural stats of all Sylveons
	#region SpeciesSylveon
	public class SpeciesSylveon : PokemonSpecies
	{
#nullable enable
		private static SpeciesSylveon? _instance = null;
#nullable restore
        public static SpeciesSylveon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSylveon();
                }
                return _instance;
            }
        }

		#region SpeciesSylveon Constructor
		public SpeciesSylveon() : base(
			700,
			"Sylveon",
			1.0,
			23.5,
			95, // HPs
			65, 65, // Attack & Defense
			110, 130, // Special Attack & Defense
			60		
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
				"Cut",
				"Sand-Attack",
				"Tackle",
				"Tail-Whip",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Calm-Mind",
				"Last-Resort",
				"Giga-Impact",
				"Psyshock",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Sylveon PokemonInstance Class
	#region Sylveon
	public class SylveonInstance : PokemonInstance
	{
		#region Sylveon Constructors
		/// <summary>
		/// Sylveon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SylveonInstance(string nickname, int level)
		: base(
				SpeciesSylveon.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sylveon Builder only waiting for a Level
		/// </summary>
		public SylveonInstance(int level)
		: base(
				SpeciesSylveon.Instance, // PokemonInstance Species
				"Sylveon", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sylveon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SylveonInstance() : base(
			SpeciesSylveon.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}