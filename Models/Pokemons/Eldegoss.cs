using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Eldegoss Species to store common natural stats of all Eldegosss
	#region SpeciesEldegoss
	public class SpeciesEldegoss : PokemonSpecies
	{
#nullable enable
		private static SpeciesEldegoss? _instance = null;
#nullable restore
        public static SpeciesEldegoss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEldegoss();
                }
                return _instance;
            }
        }

		#region SpeciesEldegoss Constructor
		public SpeciesEldegoss() : base(
			830,
			"Eldegoss",
			0.5,
			2.5,
			60, // HPs
			50, 90, // Attack & Defense
			80, 120, // Special Attack & Defense
			60		
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

	//Eldegoss PokemonInstance Class
	#region Eldegoss
	public class EldegossInstance : PokemonInstance
	{
		#region Eldegoss Constructors
		/// <summary>
		/// Eldegoss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EldegossInstance(string nickname, int level)
		: base(
				SpeciesEldegoss.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eldegoss Builder only waiting for a Level
		/// </summary>
		public EldegossInstance(int level)
		: base(
				SpeciesEldegoss.Instance, // PokemonInstance Species
				"Eldegoss", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eldegoss Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EldegossInstance() : base(
			SpeciesEldegoss.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}