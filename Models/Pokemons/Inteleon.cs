using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Inteleon Species to store common natural stats of all Inteleons
	#region SpeciesInteleon
	public class SpeciesInteleon : PokemonSpecies
	{
#nullable enable
		private static SpeciesInteleon? _instance = null;
#nullable restore
        public static SpeciesInteleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesInteleon();
                }
                return _instance;
            }
        }

		#region SpeciesInteleon Constructor
		public SpeciesInteleon() : base(
			818,
			"Inteleon",
			1.9,
			45.2,
			70, // HPs
			85, 65, // Attack & Defense
			125, 65, // Special Attack & Defense
			120		
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

	//Inteleon PokemonInstance Class
	#region Inteleon
	public class InteleonInstance : PokemonInstance
	{
		#region Inteleon Constructors
		/// <summary>
		/// Inteleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public InteleonInstance(string nickname, int level)
		: base(
				SpeciesInteleon.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inteleon Builder only waiting for a Level
		/// </summary>
		public InteleonInstance(int level)
		: base(
				SpeciesInteleon.Instance, // PokemonInstance Species
				"Inteleon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inteleon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public InteleonInstance() : base(
			SpeciesInteleon.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}