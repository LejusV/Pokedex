using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Morgrem Species to store common natural stats of all Morgrems
	#region SpeciesMorgrem
	public class SpeciesMorgrem : PokemonSpecies
	{
#nullable enable
		private static SpeciesMorgrem? _instance = null;
#nullable restore
        public static SpeciesMorgrem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMorgrem();
                }
                return _instance;
            }
        }

		#region SpeciesMorgrem Constructor
		public SpeciesMorgrem() : base(
			"Morgrem",
			0.8,
			12.5,
			65, // HPs
			60, 45, // Attack & Defense
			75, 55, // Special Attack & Defense
			70		
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

	//Morgrem PokemonInstance Class
	#region Morgrem
	public class MorgremInstance : PokemonInstance
	{
		#region Morgrem Constructors
		/// <summary>
		/// Morgrem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MorgremInstance(string nickname, int level)
		: base(
				860,
				SpeciesMorgrem.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morgrem Builder only waiting for a Level
		/// </summary>
		public MorgremInstance(int level)
		: base(
				860,
				SpeciesMorgrem.Instance, // PokemonInstance Species
				"Morgrem", level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morgrem Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Morgrem() : base(
			860,
			SpeciesMorgrem.Instance, // PokemonInstance Species
			Dark.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}