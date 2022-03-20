using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gumshoos PokemonInstance Class
	#region Gumshoos
	public class Gumshoos : PokemonInstance
	{
		#region Gumshoos Constructors
		/// <summary>
		/// Gumshoos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gumshoos(string nickname, int level)
		: base(
				GumshoosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gumshoos Constructor only waiting for a Level
		/// </summary>
		public Gumshoos(int level)
		: this( "Gumshoos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gumshoos Constructor waiting for no params
		/// </summary>
		/*
		public Gumshoos() : this( "Gumshoos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}