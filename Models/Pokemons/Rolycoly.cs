using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rolycoly Species to store common natural stats of all Rolycolys
	#region SpeciesRolycoly
	public class SpeciesRolycoly : PokemonSpecies
	{
#nullable enable
		private static SpeciesRolycoly? _instance = null;
#nullable restore
        public static SpeciesRolycoly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRolycoly();
                }
                return _instance;
            }
        }

		#region SpeciesRolycoly Constructor
		public SpeciesRolycoly() : base(
			"Rolycoly",
			0.3,
			12.0,
			30, // HPs
			40, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
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

	//Rolycoly PokemonInstance Class
	#region Rolycoly
	public class RolycolyInstance : PokemonInstance
	{
		#region Rolycoly Constructors
		/// <summary>
		/// Rolycoly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RolycolyInstance(string nickname, int level)
		: base(
				837,
				SpeciesRolycoly.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rolycoly Builder only waiting for a Level
		/// </summary>
		public RolycolyInstance(int level)
		: base(
				837,
				SpeciesRolycoly.Instance, // PokemonInstance Species
				"Rolycoly", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rolycoly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Rolycoly() : base(
			837,
			SpeciesRolycoly.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}