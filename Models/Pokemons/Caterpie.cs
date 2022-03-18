using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Caterpie Species to store common natural stats of all Caterpies
	#region SpeciesCaterpie
	public class SpeciesCaterpie : PokemonSpecies
	{
#nullable enable
		private static SpeciesCaterpie? _instance = null;
#nullable restore
        public static SpeciesCaterpie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCaterpie();
                }
                return _instance;
            }
        }

		#region SpeciesCaterpie Constructor
		public SpeciesCaterpie() : base(
			10,
			"Caterpie",
			0.3,
			2.9,
			45, // HPs
			30, 35, // Attack & Defense
			20, 20, // Special Attack & Defense
			45		
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
				"String-Shot",
				"Snore",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Caterpie PokemonInstance Class
	#region Caterpie
	public class CaterpieInstance : PokemonInstance
	{
		#region Caterpie Constructors
		/// <summary>
		/// Caterpie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CaterpieInstance(string nickname, int level)
		: base(
				SpeciesCaterpie.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Caterpie Builder only waiting for a Level
		/// </summary>
		public CaterpieInstance(int level)
		: base(
				SpeciesCaterpie.Instance, // PokemonInstance Species
				"Caterpie", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Caterpie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CaterpieInstance() : base(
			SpeciesCaterpie.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}