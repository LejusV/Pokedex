using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Boldore PokemonInstance Class
	#region Boldore
	public class Boldore : PokemonInstance
	{
		#region Boldore Constructors
		/// <summary>
		/// Boldore Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Boldore(string nickname, int level)
		: base(
				BoldoreSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boldore Constructor only waiting for a Level
		/// </summary>
		public Boldore(int level)
		: this( "Boldore", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boldore Constructor waiting for no params
		/// </summary>
		/*
		public Boldore() : this( "Boldore", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}