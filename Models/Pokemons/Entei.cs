using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Entei Species to store common natural stats of all Enteis
	#region SpeciesEntei
	public class SpeciesEntei : PokemonSpecies
	{
#nullable enable
		private static SpeciesEntei? _instance = null;
#nullable restore
        public static SpeciesEntei Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEntei();
                }
                return _instance;
            }
        }

		#region SpeciesEntei Constructor
		public SpeciesEntei() : base(
			244,
			"Entei",
			2.1,
			198.0,
			115, // HPs
			115, 85, // Attack & Defense
			90, 75, // Special Attack & Defense
			100		
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
				"Stomp",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Fire-Blast",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sacred-Fire",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Extrasensory",
				"Calm-Mind",
				"Natural-Gift",
				"Giga-Impact",
				"Fire-Fang",
				"Rock-Climb",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Quash",
				"Bulldoze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Entei PokemonInstance Class
	#region Entei
	public class EnteiInstance : PokemonInstance
	{
		#region Entei Constructors
		/// <summary>
		/// Entei Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EnteiInstance(string nickname, int level)
		: base(
				SpeciesEntei.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Entei Builder only waiting for a Level
		/// </summary>
		public EnteiInstance(int level)
		: base(
				SpeciesEntei.Instance, // PokemonInstance Species
				"Entei", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Entei Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EnteiInstance() : base(
			SpeciesEntei.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}