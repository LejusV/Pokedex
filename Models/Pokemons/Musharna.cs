using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Musharna Species to store common natural stats of all Musharnas
	#region SpeciesMusharna
	public class SpeciesMusharna : PokemonSpecies
	{
#nullable enable
		private static SpeciesMusharna? _instance = null;
#nullable restore
        public static SpeciesMusharna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMusharna();
                }
                return _instance;
            }
        }

		#region SpeciesMusharna Constructor
		public SpeciesMusharna() : base(
			518,
			"Musharna",
			1.1,
			60.5,
			116, // HPs
			55, 85, // Attack & Defense
			107, 95, // Special Attack & Defense
			29		
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
				"Psybeam",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
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
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Lucky-Chant",
				"Worry-Seed",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Musharna PokemonInstance Class
	#region Musharna
	public class MusharnaInstance : PokemonInstance
	{
		#region Musharna Constructors
		/// <summary>
		/// Musharna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MusharnaInstance(string nickname, int level)
		: base(
				SpeciesMusharna.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Musharna Builder only waiting for a Level
		/// </summary>
		public MusharnaInstance(int level)
		: base(
				SpeciesMusharna.Instance, // PokemonInstance Species
				"Musharna", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Musharna Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MusharnaInstance() : base(
			SpeciesMusharna.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}