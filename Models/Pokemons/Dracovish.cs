using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dracovish Species to store common natural stats of all Dracovishs
	#region SpeciesDracovish
	public class SpeciesDracovish : PokemonSpecies
	{
#nullable enable
		private static SpeciesDracovish? _instance = null;
#nullable restore
        public static SpeciesDracovish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDracovish();
                }
                return _instance;
            }
        }

		#region SpeciesDracovish Constructor
		public SpeciesDracovish() : base(
			"Dracovish",
			2.3,
			215.0,
			90, // HPs
			90, 100, // Attack & Defense
			70, 80, // Special Attack & Defense
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

	//Dracovish PokemonInstance Class
	#region Dracovish
	public class DracovishInstance : PokemonInstance
	{
		#region Dracovish Constructors
		/// <summary>
		/// Dracovish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DracovishInstance(string nickname, int level)
		: base(
				882,
				SpeciesDracovish.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracovish Builder only waiting for a Level
		/// </summary>
		public DracovishInstance(int level)
		: base(
				882,
				SpeciesDracovish.Instance, // PokemonInstance Species
				"Dracovish", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracovish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dracovish() : base(
			882,
			SpeciesDracovish.Instance, // PokemonInstance Species
			Water.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}