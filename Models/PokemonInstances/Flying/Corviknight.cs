using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Corviknight PokemonInstance Class
	#region Corviknight
	public class Corviknight : PokemonInstance
	{
		#region Corviknight Constructors
		/// <summary>
		/// Corviknight Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Corviknight(string nickname, int level)
		: base(
				CorviknightSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corviknight Constructor only waiting for a Level
		/// </summary>
		public Corviknight(int level)
		: this( "Corviknight", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corviknight Constructor waiting for no params
		/// </summary>
		/*
		public Corviknight() : this( "Corviknight", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}