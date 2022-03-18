using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dreepy Species to store common natural stats of all Dreepys
	#region SpeciesDreepy
	public class SpeciesDreepy : PokemonSpecies
	{
#nullable enable
		private static SpeciesDreepy? _instance = null;
#nullable restore
        public static SpeciesDreepy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDreepy();
                }
                return _instance;
            }
        }

		#region SpeciesDreepy Constructor
		public SpeciesDreepy() : base(
			885,
			"Dreepy",
			0.5,
			2.0,
			28, // HPs
			60, 30, // Attack & Defense
			40, 30, // Special Attack & Defense
			82		
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

	//Dreepy PokemonInstance Class
	#region Dreepy
	public class DreepyInstance : PokemonInstance
	{
		#region Dreepy Constructors
		/// <summary>
		/// Dreepy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DreepyInstance(string nickname, int level)
		: base(
				SpeciesDreepy.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dreepy Builder only waiting for a Level
		/// </summary>
		public DreepyInstance(int level)
		: base(
				SpeciesDreepy.Instance, // PokemonInstance Species
				"Dreepy", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dreepy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DreepyInstance() : base(
			SpeciesDreepy.Instance, // PokemonInstance Species
			Dragon.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}