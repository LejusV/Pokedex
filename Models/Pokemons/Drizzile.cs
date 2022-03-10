using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drizzile Species to store common natural stats of all Drizziles
	#region SpeciesDrizzile
	public class SpeciesDrizzile : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrizzile? _instance = null;
#nullable restore
        public static SpeciesDrizzile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrizzile();
                }
                return _instance;
            }
        }

		#region SpeciesDrizzile Constructor
		public SpeciesDrizzile() : base(
			"Drizzile",
			0.7,
			11.5,
			65, // HPs
			60, 55, // Attack & Defense
			95, 55, // Special Attack & Defense
			90		
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

	//Drizzile PokemonInstance Class
	#region Drizzile
	public class DrizzileInstance : PokemonInstance
	{
		#region Drizzile Constructors
		/// <summary>
		/// Drizzile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrizzileInstance(string nickname, int level)
		: base(
				817,
				SpeciesDrizzile.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drizzile Builder only waiting for a Level
		/// </summary>
		public DrizzileInstance(int level)
		: base(
				817,
				SpeciesDrizzile.Instance, // PokemonInstance Species
				"Drizzile", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drizzile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Drizzile() : base(
			817,
			SpeciesDrizzile.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}