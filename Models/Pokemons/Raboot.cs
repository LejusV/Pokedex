using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Raboot Species to store common natural stats of all Raboots
	#region SpeciesRaboot
	public class SpeciesRaboot : PokemonSpecies
	{
#nullable enable
		private static SpeciesRaboot? _instance = null;
#nullable restore
        public static SpeciesRaboot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRaboot();
                }
                return _instance;
            }
        }

		#region SpeciesRaboot Constructor
		public SpeciesRaboot() : base(
			814,
			"Raboot",
			0.6,
			9.0,
			65, // HPs
			86, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			94		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Raboot PokemonInstance Class
	#region Raboot
	public class RabootInstance : PokemonInstance
	{
		#region Raboot Constructors
		/// <summary>
		/// Raboot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RabootInstance(string nickname, int level)
		: base(
				SpeciesRaboot.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raboot Builder only waiting for a Level
		/// </summary>
		public RabootInstance(int level)
		: base(
				SpeciesRaboot.Instance, // PokemonInstance Species
				"Raboot", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raboot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RabootInstance() : base(
			SpeciesRaboot.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}