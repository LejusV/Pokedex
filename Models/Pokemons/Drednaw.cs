using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drednaw Species to store common natural stats of all Drednaws
	#region SpeciesDrednaw
	public class SpeciesDrednaw : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrednaw? _instance = null;
#nullable restore
        public static SpeciesDrednaw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrednaw();
                }
                return _instance;
            }
        }

		#region SpeciesDrednaw Constructor
		public SpeciesDrednaw() : base(
			834,
			"Drednaw",
			1.0,
			115.5,
			90, // HPs
			115, 90, // Attack & Defense
			48, 68, // Special Attack & Defense
			74		
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

	//Drednaw PokemonInstance Class
	#region Drednaw
	public class DrednawInstance : PokemonInstance
	{
		#region Drednaw Constructors
		/// <summary>
		/// Drednaw Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrednawInstance(string nickname, int level)
		: base(
				SpeciesDrednaw.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drednaw Builder only waiting for a Level
		/// </summary>
		public DrednawInstance(int level)
		: base(
				SpeciesDrednaw.Instance, // PokemonInstance Species
				"Drednaw", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drednaw Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DrednawInstance() : base(
			SpeciesDrednaw.Instance, // PokemonInstance Species
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}