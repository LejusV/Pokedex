using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Delcatty PokemonInstance Class
	#region Delcatty
	public class Delcatty : PokemonInstance
	{
		#region Delcatty Constructors
		/// <summary>
		/// Delcatty Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Delcatty(string nickname, int level)
		: base(
				DelcattySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delcatty Constructor only waiting for a Level
		/// </summary>
		public Delcatty(int level)
		: this( "Delcatty", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delcatty Constructor waiting for no params
		/// </summary>
		/*
		public Delcatty() : this( "Delcatty", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}