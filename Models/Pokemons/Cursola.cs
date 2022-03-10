using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cursola Species to store common natural stats of all Cursolas
	#region SpeciesCursola
	public class SpeciesCursola : PokemonSpecies
	{
#nullable enable
		private static SpeciesCursola? _instance = null;
#nullable restore
        public static SpeciesCursola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCursola();
                }
                return _instance;
            }
        }

		#region SpeciesCursola Constructor
		public SpeciesCursola() : base(
			"Cursola",
			1.0,
			0.4,
			60, // HPs
			95, 50, // Attack & Defense
			145, 130, // Special Attack & Defense
			30		
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

	//Cursola PokemonInstance Class
	#region Cursola
	public class CursolaInstance : PokemonInstance
	{
		#region Cursola Constructors
		/// <summary>
		/// Cursola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CursolaInstance(string nickname, int level)
		: base(
				864,
				SpeciesCursola.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cursola Builder only waiting for a Level
		/// </summary>
		public CursolaInstance(int level)
		: base(
				864,
				SpeciesCursola.Instance, // PokemonInstance Species
				"Cursola", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cursola Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cursola() : base(
			864,
			SpeciesCursola.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}