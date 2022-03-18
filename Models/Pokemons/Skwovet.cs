using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skwovet Species to store common natural stats of all Skwovets
	#region SpeciesSkwovet
	public class SpeciesSkwovet : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkwovet? _instance = null;
#nullable restore
        public static SpeciesSkwovet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkwovet();
                }
                return _instance;
            }
        }

		#region SpeciesSkwovet Constructor
		public SpeciesSkwovet() : base(
			819,
			"Skwovet",
			0.3,
			2.5,
			70, // HPs
			55, 55, // Attack & Defense
			35, 35, // Special Attack & Defense
			25		
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

	//Skwovet PokemonInstance Class
	#region Skwovet
	public class SkwovetInstance : PokemonInstance
	{
		#region Skwovet Constructors
		/// <summary>
		/// Skwovet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkwovetInstance(string nickname, int level)
		: base(
				SpeciesSkwovet.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skwovet Builder only waiting for a Level
		/// </summary>
		public SkwovetInstance(int level)
		: base(
				SpeciesSkwovet.Instance, // PokemonInstance Species
				"Skwovet", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skwovet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SkwovetInstance() : base(
			SpeciesSkwovet.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}