using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Thwackey Species to store common natural stats of all Thwackeys
	#region SpeciesThwackey
	public class SpeciesThwackey : PokemonSpecies
	{
#nullable enable
		private static SpeciesThwackey? _instance = null;
#nullable restore
        public static SpeciesThwackey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesThwackey();
                }
                return _instance;
            }
        }

		#region SpeciesThwackey Constructor
		public SpeciesThwackey() : base(
			"Thwackey",
			0.7,
			14.0,
			70, // HPs
			85, 70, // Attack & Defense
			55, 60, // Special Attack & Defense
			80		
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

	//Thwackey PokemonInstance Class
	#region Thwackey
	public class ThwackeyInstance : PokemonInstance
	{
		#region Thwackey Constructors
		/// <summary>
		/// Thwackey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ThwackeyInstance(string nickname, int level)
		: base(
				811,
				SpeciesThwackey.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thwackey Builder only waiting for a Level
		/// </summary>
		public ThwackeyInstance(int level)
		: base(
				811,
				SpeciesThwackey.Instance, // PokemonInstance Species
				"Thwackey", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thwackey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Thwackey() : base(
			811,
			SpeciesThwackey.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}