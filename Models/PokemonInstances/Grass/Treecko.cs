using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Treecko PokemonInstance Class
	#region Treecko
	public class Treecko : PokemonInstance
	{
		#region Treecko Constructors
		/// <summary>
		/// Treecko Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Treecko(string nickname, int level)
		: base(
				TreeckoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Treecko Constructor only waiting for a Level
		/// </summary>
		public Treecko(int level)
		: this( "Treecko", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Treecko Constructor waiting for no params
		/// </summary>
		/*
		public Treecko() : this( "Treecko", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}