using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cufant PokemonInstance Class
	#region Cufant
	public class Cufant : PokemonInstance
	{
		#region Cufant Constructors
		/// <summary>
		/// Cufant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cufant(string nickname, int level)
		: base(
				CufantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cufant Constructor only waiting for a Level
		/// </summary>
		public Cufant(int level)
		: this( "Cufant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cufant Constructor waiting for no params
		/// </summary>
		/*
		public Cufant() : this( "Cufant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}