using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scorbunny Species to store common natural stats of all Scorbunnys
	#region SpeciesScorbunny
	public class SpeciesScorbunny : PokemonSpecies
	{
#nullable enable
		private static SpeciesScorbunny? _instance = null;
#nullable restore
        public static SpeciesScorbunny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScorbunny();
                }
                return _instance;
            }
        }

		#region SpeciesScorbunny Constructor
		public SpeciesScorbunny() : base(
			813,
			"Scorbunny",
			0.3,
			4.5,
			50, // HPs
			71, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			69		
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

	//Scorbunny PokemonInstance Class
	#region Scorbunny
	public class ScorbunnyInstance : PokemonInstance
	{
		#region Scorbunny Constructors
		/// <summary>
		/// Scorbunny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScorbunnyInstance(string nickname, int level)
		: base(
				SpeciesScorbunny.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scorbunny Builder only waiting for a Level
		/// </summary>
		public ScorbunnyInstance(int level)
		: base(
				SpeciesScorbunny.Instance, // PokemonInstance Species
				"Scorbunny", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scorbunny Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ScorbunnyInstance() : base(
			SpeciesScorbunny.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}