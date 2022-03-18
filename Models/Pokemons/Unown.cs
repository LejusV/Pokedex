using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Unown Species to store common natural stats of all Unowns
	#region SpeciesUnown
	public class SpeciesUnown : PokemonSpecies
	{
#nullable enable
		private static SpeciesUnown? _instance = null;
#nullable restore
        public static SpeciesUnown Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesUnown();
                }
                return _instance;
            }
        }

		#region SpeciesUnown Constructor
		public SpeciesUnown() : base(
			201,
			"Unown",
			0.5,
			5.0,
			48, // HPs
			72, 48, // Attack & Defense
			72, 48, // Special Attack & Defense
			48		
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
				"Hidden-Power"
			};
		}
		#endregion
	}
	#endregion

	//Unown PokemonInstance Class
	#region Unown
	public class UnownInstance : PokemonInstance
	{
		#region Unown Constructors
		/// <summary>
		/// Unown Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public UnownInstance(string nickname, int level)
		: base(
				SpeciesUnown.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unown Builder only waiting for a Level
		/// </summary>
		public UnownInstance(int level)
		: base(
				SpeciesUnown.Instance, // PokemonInstance Species
				"Unown", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unown Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public UnownInstance() : base(
			SpeciesUnown.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}