using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Flapple Species to store common natural stats of all Flapples
	#region SpeciesFlapple
	public class SpeciesFlapple : PokemonSpecies
	{
#nullable enable
		private static SpeciesFlapple? _instance = null;
#nullable restore
        public static SpeciesFlapple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFlapple();
                }
                return _instance;
            }
        }

		#region SpeciesFlapple Constructor
		public SpeciesFlapple() : base(
			841,
			"Flapple",
			0.3,
			1.0,
			70, // HPs
			110, 80, // Attack & Defense
			95, 60, // Special Attack & Defense
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

	//Flapple PokemonInstance Class
	#region Flapple
	public class FlappleInstance : PokemonInstance
	{
		#region Flapple Constructors
		/// <summary>
		/// Flapple Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FlappleInstance(string nickname, int level)
		: base(
				SpeciesFlapple.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flapple Builder only waiting for a Level
		/// </summary>
		public FlappleInstance(int level)
		: base(
				SpeciesFlapple.Instance, // PokemonInstance Species
				"Flapple", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flapple Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FlappleInstance() : base(
			SpeciesFlapple.Instance, // PokemonInstance Species
			Grass.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}