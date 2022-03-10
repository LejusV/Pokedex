using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Polteageist Species to store common natural stats of all Polteageists
	#region SpeciesPolteageist
	public class SpeciesPolteageist : PokemonSpecies
	{
#nullable enable
		private static SpeciesPolteageist? _instance = null;
#nullable restore
        public static SpeciesPolteageist Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPolteageist();
                }
                return _instance;
            }
        }

		#region SpeciesPolteageist Constructor
		public SpeciesPolteageist() : base(
			"Polteageist",
			0.2,
			0.4,
			60, // HPs
			65, 65, // Attack & Defense
			134, 114, // Special Attack & Defense
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

	//Polteageist PokemonInstance Class
	#region Polteageist
	public class PolteageistInstance : PokemonInstance
	{
		#region Polteageist Constructors
		/// <summary>
		/// Polteageist Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PolteageistInstance(string nickname, int level)
		: base(
				855,
				SpeciesPolteageist.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Polteageist Builder only waiting for a Level
		/// </summary>
		public PolteageistInstance(int level)
		: base(
				855,
				SpeciesPolteageist.Instance, // PokemonInstance Species
				"Polteageist", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Polteageist Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Polteageist() : base(
			855,
			SpeciesPolteageist.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}