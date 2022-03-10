using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Centiskorch Species to store common natural stats of all Centiskorchs
	#region SpeciesCentiskorch
	public class SpeciesCentiskorch : PokemonSpecies
	{
#nullable enable
		private static SpeciesCentiskorch? _instance = null;
#nullable restore
        public static SpeciesCentiskorch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCentiskorch();
                }
                return _instance;
            }
        }

		#region SpeciesCentiskorch Constructor
		public SpeciesCentiskorch() : base(
			"Centiskorch",
			3.0,
			120.0,
			100, // HPs
			115, 65, // Attack & Defense
			90, 90, // Special Attack & Defense
			65		
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

	//Centiskorch PokemonInstance Class
	#region Centiskorch
	public class CentiskorchInstance : PokemonInstance
	{
		#region Centiskorch Constructors
		/// <summary>
		/// Centiskorch Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CentiskorchInstance(string nickname, int level)
		: base(
				851,
				SpeciesCentiskorch.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Centiskorch Builder only waiting for a Level
		/// </summary>
		public CentiskorchInstance(int level)
		: base(
				851,
				SpeciesCentiskorch.Instance, // PokemonInstance Species
				"Centiskorch", level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Centiskorch Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Centiskorch() : base(
			851,
			SpeciesCentiskorch.Instance, // PokemonInstance Species
			Fire.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}