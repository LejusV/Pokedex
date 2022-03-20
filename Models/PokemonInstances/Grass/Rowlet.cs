using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rowlet PokemonInstance Class
	#region Rowlet
	public class Rowlet : PokemonInstance
	{
		#region Rowlet Constructors
		/// <summary>
		/// Rowlet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rowlet(string nickname, int level)
		: base(
				RowletSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rowlet Constructor only waiting for a Level
		/// </summary>
		public Rowlet(int level)
		: this( "Rowlet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rowlet Constructor waiting for no params
		/// </summary>
		/*
		public Rowlet() : this( "Rowlet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}