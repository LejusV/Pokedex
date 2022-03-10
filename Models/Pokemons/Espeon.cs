using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Espeon Species to store common natural stats of all Espeons
	#region SpeciesEspeon
	public class SpeciesEspeon : PokemonSpecies
	{
#nullable enable
		private static SpeciesEspeon? _instance = null;
#nullable restore
        public static SpeciesEspeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEspeon();
                }
                return _instance;
            }
        }

		#region SpeciesEspeon Constructor
		public SpeciesEspeon() : base(
			"Espeon",
			0.9,
			26.5,
			65, // HPs
			65, 60, // Attack & Defense
			130, 95, // Special Attack & Defense
			110		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Psybeam",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Morning-Sun",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Power-Swap",
				"Last-Resort",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Espeon PokemonInstance Class
	#region Espeon
	public class EspeonInstance : PokemonInstance
	{
		#region Espeon Constructors
		/// <summary>
		/// Espeon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EspeonInstance(string nickname, int level)
		: base(
				196,
				SpeciesEspeon.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espeon Builder only waiting for a Level
		/// </summary>
		public EspeonInstance(int level)
		: base(
				196,
				SpeciesEspeon.Instance, // PokemonInstance Species
				"Espeon", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espeon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Espeon() : base(
			196,
			SpeciesEspeon.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}