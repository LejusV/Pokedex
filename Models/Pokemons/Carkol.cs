using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Carkol Species to store common natural stats of all Carkols
	#region SpeciesCarkol
	public class SpeciesCarkol : PokemonSpecies
	{
#nullable enable
		private static SpeciesCarkol? _instance = null;
#nullable restore
        public static SpeciesCarkol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCarkol();
                }
                return _instance;
            }
        }

		#region SpeciesCarkol Constructor
		public SpeciesCarkol() : base(
			"Carkol",
			1.1,
			78.0,
			80, // HPs
			60, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			50		
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

	//Carkol PokemonInstance Class
	#region Carkol
	public class CarkolInstance : PokemonInstance
	{
		#region Carkol Constructors
		/// <summary>
		/// Carkol Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CarkolInstance(string nickname, int level)
		: base(
				838,
				SpeciesCarkol.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carkol Builder only waiting for a Level
		/// </summary>
		public CarkolInstance(int level)
		: base(
				838,
				SpeciesCarkol.Instance, // PokemonInstance Species
				"Carkol", level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carkol Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Carkol() : base(
			838,
			SpeciesCarkol.Instance, // PokemonInstance Species
			Rock.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}