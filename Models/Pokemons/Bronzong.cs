using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bronzong Species to store common natural stats of all Bronzongs
	#region SpeciesBronzong
	public class SpeciesBronzong : PokemonSpecies
	{
#nullable enable
		private static SpeciesBronzong? _instance = null;
#nullable restore
        public static SpeciesBronzong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBronzong();
                }
                return _instance;
            }
        }

		#region SpeciesBronzong Constructor
		public SpeciesBronzong() : base(
			437,
			"Bronzong",
			1.3,
			187.0,
			67, // HPs
			89, 116, // Attack & Defense
			79, 116, // Special Attack & Defense
			33		
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
				"Hyper-Beam",
				"Strength",
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
				"Explosion",
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
				"Rock-Smash",
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
				"Block",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Heal-Block",
				"Rock-Polish",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
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

	//Bronzong PokemonInstance Class
	#region Bronzong
	public class BronzongInstance : PokemonInstance
	{
		#region Bronzong Constructors
		/// <summary>
		/// Bronzong Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BronzongInstance(string nickname, int level)
		: base(
				SpeciesBronzong.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzong Builder only waiting for a Level
		/// </summary>
		public BronzongInstance(int level)
		: base(
				SpeciesBronzong.Instance, // PokemonInstance Species
				"Bronzong", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzong Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BronzongInstance() : base(
			SpeciesBronzong.Instance, // PokemonInstance Species
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}