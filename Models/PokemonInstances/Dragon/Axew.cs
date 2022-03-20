using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Axew PokemonInstance Class
	#region Axew
	public class Axew : PokemonInstance
	{
		#region Axew Constructors
		/// <summary>
		/// Axew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Axew(string nickname, int level)
		: base(
				AxewSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Axew Constructor only waiting for a Level
		/// </summary>
		public Axew(int level)
		: this( "Axew", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Axew Constructor waiting for no params
		/// </summary>
		/*
		public Axew() : this( "Axew", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}