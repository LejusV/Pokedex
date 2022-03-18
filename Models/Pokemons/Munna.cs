using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Munna Species to store common natural stats of all Munnas
	#region SpeciesMunna
	public class SpeciesMunna : PokemonSpecies
	{
#nullable enable
		private static SpeciesMunna? _instance = null;
#nullable restore
        public static SpeciesMunna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMunna();
                }
                return _instance;
            }
        }

		#region SpeciesMunna Constructor
		public SpeciesMunna() : base(
			517,
			"Munna",
			0.6,
			23.3,
			76, // HPs
			25, 45, // Attack & Defense
			67, 55, // Special Attack & Defense
			24		
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
				"Sonic-Boom",
				"Psybeam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Defense-Curl",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Baton-Pass",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Yawn",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Healing-Wish",
				"Lucky-Chant",
				"Worry-Seed",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"After-You",
				"Round",
				"Stored-Power",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Munna PokemonInstance Class
	#region Munna
	public class MunnaInstance : PokemonInstance
	{
		#region Munna Constructors
		/// <summary>
		/// Munna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MunnaInstance(string nickname, int level)
		: base(
				SpeciesMunna.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munna Builder only waiting for a Level
		/// </summary>
		public MunnaInstance(int level)
		: base(
				SpeciesMunna.Instance, // PokemonInstance Species
				"Munna", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munna Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MunnaInstance() : base(
			SpeciesMunna.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}