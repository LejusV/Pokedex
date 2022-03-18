using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Luxio Species to store common natural stats of all Luxios
	#region SpeciesLuxio
	public class SpeciesLuxio : PokemonSpecies
	{
#nullable enable
		private static SpeciesLuxio? _instance = null;
#nullable restore
        public static SpeciesLuxio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLuxio();
                }
                return _instance;
            }
        }

		#region SpeciesLuxio Constructor
		public SpeciesLuxio() : base(
			404,
			"Luxio",
			0.9,
			30.5,
			60, // HPs
			85, 49, // Attack & Defense
			60, 49, // Special Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Leer",
				"Bite",
				"Roar",
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
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Thunder-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Luxio PokemonInstance Class
	#region Luxio
	public class LuxioInstance : PokemonInstance
	{
		#region Luxio Constructors
		/// <summary>
		/// Luxio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LuxioInstance(string nickname, int level)
		: base(
				SpeciesLuxio.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxio Builder only waiting for a Level
		/// </summary>
		public LuxioInstance(int level)
		: base(
				SpeciesLuxio.Instance, // PokemonInstance Species
				"Luxio", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxio Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LuxioInstance() : base(
			SpeciesLuxio.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}