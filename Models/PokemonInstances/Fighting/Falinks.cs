using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Falinks PokemonInstance Class
	#region Falinks
	public class Falinks : PokemonInstance
	{
		#region Falinks Constructors
		/// <summary>
		/// Falinks Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Falinks(string nickname, int level)
		: base(
				FalinksSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Falinks Constructor only waiting for a Level
		/// </summary>
		public Falinks(int level)
		: this( "Falinks", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Falinks Constructor waiting for no params
		/// </summary>
		/*
		public Falinks() : this( "Falinks", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}