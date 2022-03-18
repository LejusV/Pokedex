using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Snom Species to store common natural stats of all Snoms
	#region SpeciesSnom
	public class SpeciesSnom : PokemonSpecies
	{
#nullable enable
		private static SpeciesSnom? _instance = null;
#nullable restore
        public static SpeciesSnom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSnom();
                }
                return _instance;
            }
        }

		#region SpeciesSnom Constructor
		public SpeciesSnom() : base(
			872,
			"Snom",
			0.3,
			3.8,
			30, // HPs
			25, 35, // Attack & Defense
			45, 30, // Special Attack & Defense
			20		
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

	//Snom PokemonInstance Class
	#region Snom
	public class SnomInstance : PokemonInstance
	{
		#region Snom Constructors
		/// <summary>
		/// Snom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SnomInstance(string nickname, int level)
		: base(
				SpeciesSnom.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snom Builder only waiting for a Level
		/// </summary>
		public SnomInstance(int level)
		: base(
				SpeciesSnom.Instance, // PokemonInstance Species
				"Snom", level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SnomInstance() : base(
			SpeciesSnom.Instance, // PokemonInstance Species
			Ice.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}