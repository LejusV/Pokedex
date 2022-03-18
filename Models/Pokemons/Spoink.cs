using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spoink Species to store common natural stats of all Spoinks
	#region SpeciesSpoink
	public class SpeciesSpoink : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpoink? _instance = null;
#nullable restore
        public static SpeciesSpoink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpoink();
                }
                return _instance;
            }
        }

		#region SpeciesSpoink Constructor
		public SpeciesSpoink() : base(
			325,
			"Spoink",
			0.7,
			30.6,
			60, // HPs
			25, 35, // Attack & Defense
			70, 80, // Special Attack & Defense
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
				"Whirlwind",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Psybeam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Odor-Sleuth",
				"Signal-Beam",
				"Extrasensory",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Lucky-Chant",
				"Power-Gem",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Simple-Beam",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Spoink PokemonInstance Class
	#region Spoink
	public class SpoinkInstance : PokemonInstance
	{
		#region Spoink Constructors
		/// <summary>
		/// Spoink Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpoinkInstance(string nickname, int level)
		: base(
				SpeciesSpoink.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spoink Builder only waiting for a Level
		/// </summary>
		public SpoinkInstance(int level)
		: base(
				SpeciesSpoink.Instance, // PokemonInstance Species
				"Spoink", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spoink Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SpoinkInstance() : base(
			SpeciesSpoink.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}