using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Taillow PokemonInstance Class
	#region Taillow
	public class Taillow : PokemonInstance
	{
		#region Taillow Constructors
		/// <summary>
		/// Taillow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Taillow(string nickname, int level)
		: base(
				TaillowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Taillow Constructor only waiting for a Level
		/// </summary>
		public Taillow(int level)
		: this( "Taillow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Taillow Constructor waiting for no params
		/// </summary>
		/*
		public Taillow() : this( "Taillow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}