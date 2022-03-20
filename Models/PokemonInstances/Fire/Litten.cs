using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Litten PokemonInstance Class
	#region Litten
	public class Litten : PokemonInstance
	{
		#region Litten Constructors
		/// <summary>
		/// Litten Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Litten(string nickname, int level)
		: base(
				LittenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litten Constructor only waiting for a Level
		/// </summary>
		public Litten(int level)
		: this( "Litten", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litten Constructor waiting for no params
		/// </summary>
		/*
		public Litten() : this( "Litten", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}