using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bronzor Species to store common natural stats of all Bronzors
	#region SpeciesBronzor
	public class SpeciesBronzor : PokemonSpecies
	{
#nullable enable
		private static SpeciesBronzor? _instance = null;
#nullable restore
        public static SpeciesBronzor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBronzor();
                }
                return _instance;
            }
        }

		#region SpeciesBronzor Constructor
		public SpeciesBronzor() : base(
			436,
			"Bronzor",
			0.5,
			60.5,
			57, // HPs
			24, 86, // Attack & Defense
			24, 86, // Special Attack & Defense
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
				"Tackle",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Trick",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Signal-Beam",
				"Extrasensory",
				"Iron-Defense",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Heal-Block",
				"Rock-Polish",
				"Flash-Cannon",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Bronzor PokemonInstance Class
	#region Bronzor
	public class BronzorInstance : PokemonInstance
	{
		#region Bronzor Constructors
		/// <summary>
		/// Bronzor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BronzorInstance(string nickname, int level)
		: base(
				SpeciesBronzor.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzor Builder only waiting for a Level
		/// </summary>
		public BronzorInstance(int level)
		: base(
				SpeciesBronzor.Instance, // PokemonInstance Species
				"Bronzor", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BronzorInstance() : base(
			SpeciesBronzor.Instance, // PokemonInstance Species
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}