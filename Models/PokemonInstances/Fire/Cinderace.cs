using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cinderace PokemonInstance Class
	#region Cinderace
	public class Cinderace : PokemonInstance
	{
		#region Cinderace Constructors
		/// <summary>
		/// Cinderace Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cinderace(string nickname, int level)
		: base(
				CinderaceSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinderace Constructor only waiting for a Level
		/// </summary>
		public Cinderace(int level)
		: this( "Cinderace", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinderace Constructor waiting for no params
		/// </summary>
		/*
		public Cinderace() : this( "Cinderace", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}