using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Arctozolt Species to store common natural stats of all Arctozolts
	#region SpeciesArctozolt
	public class SpeciesArctozolt : PokemonSpecies
	{
#nullable enable
		private static SpeciesArctozolt? _instance = null;
#nullable restore
        public static SpeciesArctozolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArctozolt();
                }
                return _instance;
            }
        }

		#region SpeciesArctozolt Constructor
		public SpeciesArctozolt() : base(
			881,
			"Arctozolt",
			2.3,
			150.0,
			90, // HPs
			100, 90, // Attack & Defense
			90, 80, // Special Attack & Defense
			55		
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

	//Arctozolt PokemonInstance Class
	#region Arctozolt
	public class ArctozoltInstance : PokemonInstance
	{
		#region Arctozolt Constructors
		/// <summary>
		/// Arctozolt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArctozoltInstance(string nickname, int level)
		: base(
				SpeciesArctozolt.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctozolt Builder only waiting for a Level
		/// </summary>
		public ArctozoltInstance(int level)
		: base(
				SpeciesArctozolt.Instance, // PokemonInstance Species
				"Arctozolt", level,
				Electric.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctozolt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ArctozoltInstance() : base(
			SpeciesArctozolt.Instance, // PokemonInstance Species
			Electric.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}