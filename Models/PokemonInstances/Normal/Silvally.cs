using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Silvally PokemonInstance Class
	#region Silvally
	public class Silvally : PokemonInstance
	{
		#region Silvally Constructors
		/// <summary>
		/// Silvally Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Silvally(string nickname, int level)
		: base(
				SilvallySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silvally Constructor only waiting for a Level
		/// </summary>
		public Silvally(int level)
		: this( "Silvally", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silvally Constructor waiting for no params
		/// </summary>
		/*
		public Silvally() : this( "Silvally", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}