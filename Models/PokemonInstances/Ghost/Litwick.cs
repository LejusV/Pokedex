using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Litwick PokemonInstance Class
	#region Litwick
	public class Litwick : PokemonInstance
	{
		#region Litwick Constructors
		/// <summary>
		/// Litwick Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Litwick(string nickname, int level)
		: base(
				LitwickSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litwick Constructor only waiting for a Level
		/// </summary>
		public Litwick(int level)
		: this( "Litwick", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litwick Constructor waiting for no params
		/// </summary>
		/*
		public Litwick() : this( "Litwick", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}