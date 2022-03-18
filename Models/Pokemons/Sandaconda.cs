using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sandaconda Species to store common natural stats of all Sandacondas
	#region SpeciesSandaconda
	public class SpeciesSandaconda : PokemonSpecies
	{
#nullable enable
		private static SpeciesSandaconda? _instance = null;
#nullable restore
        public static SpeciesSandaconda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSandaconda();
                }
                return _instance;
            }
        }

		#region SpeciesSandaconda Constructor
		public SpeciesSandaconda() : base(
			844,
			"Sandaconda",
			3.8,
			65.5,
			72, // HPs
			107, 125, // Attack & Defense
			65, 70, // Special Attack & Defense
			71		
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

	//Sandaconda PokemonInstance Class
	#region Sandaconda
	public class SandacondaInstance : PokemonInstance
	{
		#region Sandaconda Constructors
		/// <summary>
		/// Sandaconda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SandacondaInstance(string nickname, int level)
		: base(
				SpeciesSandaconda.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandaconda Builder only waiting for a Level
		/// </summary>
		public SandacondaInstance(int level)
		: base(
				SpeciesSandaconda.Instance, // PokemonInstance Species
				"Sandaconda", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandaconda Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SandacondaInstance() : base(
			SpeciesSandaconda.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}