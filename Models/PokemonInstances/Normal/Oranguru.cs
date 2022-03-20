using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Oranguru PokemonInstance Class
	#region Oranguru
	public class Oranguru : PokemonInstance
	{
		#region Oranguru Constructors
		/// <summary>
		/// Oranguru Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Oranguru(string nickname, int level)
		: base(
				OranguruSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oranguru Constructor only waiting for a Level
		/// </summary>
		public Oranguru(int level)
		: this( "Oranguru", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oranguru Constructor waiting for no params
		/// </summary>
		/*
		public Oranguru() : this( "Oranguru", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}