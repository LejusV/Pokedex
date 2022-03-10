using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Silicobra Species to store common natural stats of all Silicobras
	#region SpeciesSilicobra
	public class SpeciesSilicobra : PokemonSpecies
	{
#nullable enable
		private static SpeciesSilicobra? _instance = null;
#nullable restore
        public static SpeciesSilicobra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSilicobra();
                }
                return _instance;
            }
        }

		#region SpeciesSilicobra Constructor
		public SpeciesSilicobra() : base(
			"Silicobra",
			2.2,
			7.6,
			52, // HPs
			57, 75, // Attack & Defense
			35, 50, // Special Attack & Defense
			46		
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

	//Silicobra PokemonInstance Class
	#region Silicobra
	public class SilicobraInstance : PokemonInstance
	{
		#region Silicobra Constructors
		/// <summary>
		/// Silicobra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SilicobraInstance(string nickname, int level)
		: base(
				843,
				SpeciesSilicobra.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silicobra Builder only waiting for a Level
		/// </summary>
		public SilicobraInstance(int level)
		: base(
				843,
				SpeciesSilicobra.Instance, // PokemonInstance Species
				"Silicobra", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silicobra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Silicobra() : base(
			843,
			SpeciesSilicobra.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}