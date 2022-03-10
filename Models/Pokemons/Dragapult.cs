using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dragapult Species to store common natural stats of all Dragapults
	#region SpeciesDragapult
	public class SpeciesDragapult : PokemonSpecies
	{
#nullable enable
		private static SpeciesDragapult? _instance = null;
#nullable restore
        public static SpeciesDragapult Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDragapult();
                }
                return _instance;
            }
        }

		#region SpeciesDragapult Constructor
		public SpeciesDragapult() : base(
			"Dragapult",
			3.0,
			50.0,
			88, // HPs
			120, 75, // Attack & Defense
			100, 75, // Special Attack & Defense
			142		
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

	//Dragapult PokemonInstance Class
	#region Dragapult
	public class DragapultInstance : PokemonInstance
	{
		#region Dragapult Constructors
		/// <summary>
		/// Dragapult Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DragapultInstance(string nickname, int level)
		: base(
				887,
				SpeciesDragapult.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragapult Builder only waiting for a Level
		/// </summary>
		public DragapultInstance(int level)
		: base(
				887,
				SpeciesDragapult.Instance, // PokemonInstance Species
				"Dragapult", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragapult Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dragapult() : base(
			887,
			SpeciesDragapult.Instance, // PokemonInstance Species
			Dragon.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}