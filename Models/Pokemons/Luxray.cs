using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Luxray Species to store common natural stats of all Luxrays
	#region SpeciesLuxray
	public class SpeciesLuxray : PokemonSpecies
	{
#nullable enable
		private static SpeciesLuxray? _instance = null;
#nullable restore
        public static SpeciesLuxray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLuxray();
                }
                return _instance;
            }
        }

		#region SpeciesLuxray Constructor
		public SpeciesLuxray() : base(
			405,
			"Luxray",
			1.4,
			42.0,
			80, // HPs
			120, 79, // Attack & Defense
			95, 79, // Special Attack & Defense
			70		
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
				"Headbutt",
				"Tackle",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Luxray PokemonInstance Class
	#region Luxray
	public class LuxrayInstance : PokemonInstance
	{
		#region Luxray Constructors
		/// <summary>
		/// Luxray Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LuxrayInstance(string nickname, int level)
		: base(
				SpeciesLuxray.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxray Builder only waiting for a Level
		/// </summary>
		public LuxrayInstance(int level)
		: base(
				SpeciesLuxray.Instance, // PokemonInstance Species
				"Luxray", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxray Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LuxrayInstance() : base(
			SpeciesLuxray.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}