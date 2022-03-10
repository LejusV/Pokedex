using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dracozolt Species to store common natural stats of all Dracozolts
	#region SpeciesDracozolt
	public class SpeciesDracozolt : PokemonSpecies
	{
#nullable enable
		private static SpeciesDracozolt? _instance = null;
#nullable restore
        public static SpeciesDracozolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDracozolt();
                }
                return _instance;
            }
        }

		#region SpeciesDracozolt Constructor
		public SpeciesDracozolt() : base(
			"Dracozolt",
			1.8,
			190.0,
			90, // HPs
			100, 90, // Attack & Defense
			80, 70, // Special Attack & Defense
			75		
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

	//Dracozolt PokemonInstance Class
	#region Dracozolt
	public class DracozoltInstance : PokemonInstance
	{
		#region Dracozolt Constructors
		/// <summary>
		/// Dracozolt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DracozoltInstance(string nickname, int level)
		: base(
				880,
				SpeciesDracozolt.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracozolt Builder only waiting for a Level
		/// </summary>
		public DracozoltInstance(int level)
		: base(
				880,
				SpeciesDracozolt.Instance, // PokemonInstance Species
				"Dracozolt", level,
				Electric.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracozolt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dracozolt() : base(
			880,
			SpeciesDracozolt.Instance, // PokemonInstance Species
			Electric.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}