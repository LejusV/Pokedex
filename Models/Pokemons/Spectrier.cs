using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spectrier Species to store common natural stats of all Spectriers
	#region SpeciesSpectrier
	public class SpeciesSpectrier : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpectrier? _instance = null;
#nullable restore
        public static SpeciesSpectrier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpectrier();
                }
                return _instance;
            }
        }

		#region SpeciesSpectrier Constructor
		public SpeciesSpectrier() : base(
			"Spectrier",
			2.0,
			44.5,
			100, // HPs
			65, 60, // Attack & Defense
			145, 80, // Special Attack & Defense
			130		
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

	//Spectrier PokemonInstance Class
	#region Spectrier
	public class SpectrierInstance : PokemonInstance
	{
		#region Spectrier Constructors
		/// <summary>
		/// Spectrier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpectrierInstance(string nickname, int level)
		: base(
				897,
				SpeciesSpectrier.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spectrier Builder only waiting for a Level
		/// </summary>
		public SpectrierInstance(int level)
		: base(
				897,
				SpeciesSpectrier.Instance, // PokemonInstance Species
				"Spectrier", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spectrier Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Spectrier() : base(
			897,
			SpeciesSpectrier.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}