using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mew PokemonInstance Class
	#region Mew
	public class Mew : PokemonInstance
	{
		#region Mew Constructors
		/// <summary>
		/// Mew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mew(string nickname, int level)
		: base(
				MewSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mew Constructor only waiting for a Level
		/// </summary>
		public Mew(int level)
		: this( "Mew", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mew Constructor waiting for no params
		/// </summary>
		/*
		public Mew() : this( "Mew", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}