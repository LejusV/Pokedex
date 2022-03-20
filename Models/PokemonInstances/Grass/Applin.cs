using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Applin PokemonInstance Class
	#region Applin
	public class Applin : PokemonInstance
	{
		#region Applin Constructors
		/// <summary>
		/// Applin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Applin(string nickname, int level)
		: base(
				ApplinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Applin Constructor only waiting for a Level
		/// </summary>
		public Applin(int level)
		: this( "Applin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Applin Constructor waiting for no params
		/// </summary>
		/*
		public Applin() : this( "Applin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}