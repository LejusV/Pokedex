using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Yamper Species to store common natural stats of all Yampers
	#region SpeciesYamper
	public class SpeciesYamper : PokemonSpecies
	{
#nullable enable
		private static SpeciesYamper? _instance = null;
#nullable restore
        public static SpeciesYamper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesYamper();
                }
                return _instance;
            }
        }

		#region SpeciesYamper Constructor
		public SpeciesYamper() : base(
			"Yamper",
			0.3,
			13.5,
			59, // HPs
			45, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			26		
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

	//Yamper PokemonInstance Class
	#region Yamper
	public class YamperInstance : PokemonInstance
	{
		#region Yamper Constructors
		/// <summary>
		/// Yamper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public YamperInstance(string nickname, int level)
		: base(
				835,
				SpeciesYamper.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamper Builder only waiting for a Level
		/// </summary>
		public YamperInstance(int level)
		: base(
				835,
				SpeciesYamper.Instance, // PokemonInstance Species
				"Yamper", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamper Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Yamper() : base(
			835,
			SpeciesYamper.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}