using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wurmple Species to store common natural stats of all Wurmples
	#region SpeciesWurmple
	public class SpeciesWurmple : PokemonSpecies
	{
#nullable enable
		private static SpeciesWurmple? _instance = null;
#nullable restore
        public static SpeciesWurmple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWurmple();
                }
                return _instance;
            }
        }

		#region SpeciesWurmple Constructor
		public SpeciesWurmple() : base(
			265,
			"Wurmple",
			0.3,
			3.6,
			45, // HPs
			45, 35, // Attack & Defense
			20, 30, // Special Attack & Defense
			20		
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
				"Tackle",
				"Poison-Sting",
				"String-Shot",
				"Snore",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Wurmple PokemonInstance Class
	#region Wurmple
	public class WurmpleInstance : PokemonInstance
	{
		#region Wurmple Constructors
		/// <summary>
		/// Wurmple Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WurmpleInstance(string nickname, int level)
		: base(
				SpeciesWurmple.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wurmple Builder only waiting for a Level
		/// </summary>
		public WurmpleInstance(int level)
		: base(
				SpeciesWurmple.Instance, // PokemonInstance Species
				"Wurmple", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wurmple Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WurmpleInstance() : base(
			SpeciesWurmple.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}