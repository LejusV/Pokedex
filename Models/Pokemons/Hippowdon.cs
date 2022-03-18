using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hippowdon Species to store common natural stats of all Hippowdons
	#region SpeciesHippowdon
	public class SpeciesHippowdon : PokemonSpecies
	{
#nullable enable
		private static SpeciesHippowdon? _instance = null;
#nullable restore
        public static SpeciesHippowdon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHippowdon();
                }
                return _instance;
            }
        }

		#region SpeciesHippowdon Constructor
		public SpeciesHippowdon() : base(
			450,
			"Hippowdon",
			2.0,
			300.0,
			108, // HPs
			112, 118, // Attack & Defense
			68, 72, // Special Attack & Defense
			47		
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Water-Pulse",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Hippowdon PokemonInstance Class
	#region Hippowdon
	public class HippowdonInstance : PokemonInstance
	{
		#region Hippowdon Constructors
		/// <summary>
		/// Hippowdon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HippowdonInstance(string nickname, int level)
		: base(
				SpeciesHippowdon.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippowdon Builder only waiting for a Level
		/// </summary>
		public HippowdonInstance(int level)
		: base(
				SpeciesHippowdon.Instance, // PokemonInstance Species
				"Hippowdon", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippowdon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HippowdonInstance() : base(
			SpeciesHippowdon.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}