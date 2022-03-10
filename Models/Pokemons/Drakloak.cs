using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drakloak Species to store common natural stats of all Drakloaks
	#region SpeciesDrakloak
	public class SpeciesDrakloak : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrakloak? _instance = null;
#nullable restore
        public static SpeciesDrakloak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrakloak();
                }
                return _instance;
            }
        }

		#region SpeciesDrakloak Constructor
		public SpeciesDrakloak() : base(
			"Drakloak",
			1.4,
			11.0,
			68, // HPs
			80, 50, // Attack & Defense
			60, 50, // Special Attack & Defense
			102		
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

	//Drakloak PokemonInstance Class
	#region Drakloak
	public class DrakloakInstance : PokemonInstance
	{
		#region Drakloak Constructors
		/// <summary>
		/// Drakloak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrakloakInstance(string nickname, int level)
		: base(
				886,
				SpeciesDrakloak.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drakloak Builder only waiting for a Level
		/// </summary>
		public DrakloakInstance(int level)
		: base(
				886,
				SpeciesDrakloak.Instance, // PokemonInstance Species
				"Drakloak", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drakloak Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Drakloak() : base(
			886,
			SpeciesDrakloak.Instance, // PokemonInstance Species
			Dragon.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}