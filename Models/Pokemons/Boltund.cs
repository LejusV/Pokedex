using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Boltund Species to store common natural stats of all Boltunds
	#region SpeciesBoltund
	public class SpeciesBoltund : PokemonSpecies
	{
#nullable enable
		private static SpeciesBoltund? _instance = null;
#nullable restore
        public static SpeciesBoltund Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBoltund();
                }
                return _instance;
            }
        }

		#region SpeciesBoltund Constructor
		public SpeciesBoltund() : base(
			836,
			"Boltund",
			1.0,
			34.0,
			69, // HPs
			90, 60, // Attack & Defense
			90, 60, // Special Attack & Defense
			121		
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

	//Boltund PokemonInstance Class
	#region Boltund
	public class BoltundInstance : PokemonInstance
	{
		#region Boltund Constructors
		/// <summary>
		/// Boltund Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BoltundInstance(string nickname, int level)
		: base(
				SpeciesBoltund.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boltund Builder only waiting for a Level
		/// </summary>
		public BoltundInstance(int level)
		: base(
				SpeciesBoltund.Instance, // PokemonInstance Species
				"Boltund", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boltund Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BoltundInstance() : base(
			SpeciesBoltund.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}