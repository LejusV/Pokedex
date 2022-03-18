using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spritzee Species to store common natural stats of all Spritzees
	#region SpeciesSpritzee
	public class SpeciesSpritzee : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpritzee? _instance = null;
#nullable restore
        public static SpeciesSpritzee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpritzee();
                }
                return _instance;
            }
        }

		#region SpeciesSpritzee Constructor
		public SpeciesSpritzee() : base(
			682,
			"Spritzee",
			0.2,
			0.5,
			78, // HPs
			52, 60, // Attack & Defense
			63, 65, // Special Attack & Defense
			23		
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
				"Disable",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Endeavor",
				"Skill-Swap",
				"Refresh",
				"Secret-Power",
				"Aromatherapy",
				"Odor-Sleuth",
				"Covet",
				"Calm-Mind",
				"Gyro-Ball",
				"Energy-Ball",
				"Nasty-Plot",
				"Flash-Cannon",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Spritzee PokemonInstance Class
	#region Spritzee
	public class SpritzeeInstance : PokemonInstance
	{
		#region Spritzee Constructors
		/// <summary>
		/// Spritzee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpritzeeInstance(string nickname, int level)
		: base(
				SpeciesSpritzee.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spritzee Builder only waiting for a Level
		/// </summary>
		public SpritzeeInstance(int level)
		: base(
				SpeciesSpritzee.Instance, // PokemonInstance Species
				"Spritzee", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spritzee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SpritzeeInstance() : base(
			SpeciesSpritzee.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}