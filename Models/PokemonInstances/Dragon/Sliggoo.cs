using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sliggoo PokemonInstance Class
	#region Sliggoo
	public class Sliggoo : PokemonInstance
	{
		#region Sliggoo Constructors
		/// <summary>
		/// Sliggoo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sliggoo(string nickname, int level)
		: base(
				SliggooSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sliggoo Constructor only waiting for a Level
		/// </summary>
		public Sliggoo(int level)
		: this( "Sliggoo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sliggoo Constructor waiting for no params
		/// </summary>
		/*
		public Sliggoo() : this( "Sliggoo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}