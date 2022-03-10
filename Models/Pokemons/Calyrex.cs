using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Calyrex Species to store common natural stats of all Calyrexs
	#region SpeciesCalyrex
	public class SpeciesCalyrex : PokemonSpecies
	{
#nullable enable
		private static SpeciesCalyrex? _instance = null;
#nullable restore
        public static SpeciesCalyrex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCalyrex();
                }
                return _instance;
            }
        }

		#region SpeciesCalyrex Constructor
		public SpeciesCalyrex() : base(
			"Calyrex",
			1.1,
			7.7,
			100, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
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

	//Calyrex PokemonInstance Class
	#region Calyrex
	public class CalyrexInstance : PokemonInstance
	{
		#region Calyrex Constructors
		/// <summary>
		/// Calyrex Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CalyrexInstance(string nickname, int level)
		: base(
				898,
				SpeciesCalyrex.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Calyrex Builder only waiting for a Level
		/// </summary>
		public CalyrexInstance(int level)
		: base(
				898,
				SpeciesCalyrex.Instance, // PokemonInstance Species
				"Calyrex", level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Calyrex Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Calyrex() : base(
			898,
			SpeciesCalyrex.Instance, // PokemonInstance Species
			Psychic.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}