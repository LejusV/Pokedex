using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dottler Species to store common natural stats of all Dottlers
	#region SpeciesDottler
	public class SpeciesDottler : PokemonSpecies
	{
#nullable enable
		private static SpeciesDottler? _instance = null;
#nullable restore
        public static SpeciesDottler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDottler();
                }
                return _instance;
            }
        }

		#region SpeciesDottler Constructor
		public SpeciesDottler() : base(
			"Dottler",
			0.4,
			19.5,
			50, // HPs
			35, 80, // Attack & Defense
			50, 90, // Special Attack & Defense
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

	//Dottler PokemonInstance Class
	#region Dottler
	public class DottlerInstance : PokemonInstance
	{
		#region Dottler Constructors
		/// <summary>
		/// Dottler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DottlerInstance(string nickname, int level)
		: base(
				825,
				SpeciesDottler.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dottler Builder only waiting for a Level
		/// </summary>
		public DottlerInstance(int level)
		: base(
				825,
				SpeciesDottler.Instance, // PokemonInstance Species
				"Dottler", level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dottler Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dottler() : base(
			825,
			SpeciesDottler.Instance, // PokemonInstance Species
			Bug.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}