using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wynaut Species to store common natural stats of all Wynauts
	#region SpeciesWynaut
	public class SpeciesWynaut : PokemonSpecies
	{
#nullable enable
		private static SpeciesWynaut? _instance = null;
#nullable restore
        public static SpeciesWynaut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWynaut();
                }
                return _instance;
            }
        }

		#region SpeciesWynaut Constructor
		public SpeciesWynaut() : base(
			"Wynaut",
			0.6,
			14.0,
			95, // HPs
			23, 48, // Attack & Defense
			23, 48, // Special Attack & Defense
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
				"Counter",
				"Splash",
				"Destiny-Bond",
				"Charm",
				"Safeguard",
				"Encore",
				"Mirror-Coat"
			};
		}
		#endregion
	}
	#endregion

	//Wynaut PokemonInstance Class
	#region Wynaut
	public class WynautInstance : PokemonInstance
	{
		#region Wynaut Constructors
		/// <summary>
		/// Wynaut Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WynautInstance(string nickname, int level)
		: base(
				360,
				SpeciesWynaut.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wynaut Builder only waiting for a Level
		/// </summary>
		public WynautInstance(int level)
		: base(
				360,
				SpeciesWynaut.Instance, // PokemonInstance Species
				"Wynaut", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wynaut Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wynaut() : base(
			360,
			SpeciesWynaut.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}