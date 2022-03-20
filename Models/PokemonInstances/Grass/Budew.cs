using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Budew PokemonInstance Class
	#region Budew
	public class Budew : PokemonInstance
	{
		#region Budew Constructors
		/// <summary>
		/// Budew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Budew(string nickname, int level)
		: base(
				BudewSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Budew Constructor only waiting for a Level
		/// </summary>
		public Budew(int level)
		: this( "Budew", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Budew Constructor waiting for no params
		/// </summary>
		/*
		public Budew() : this( "Budew", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}