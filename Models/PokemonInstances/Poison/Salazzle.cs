using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Salazzle PokemonInstance Class
	#region Salazzle
	public class Salazzle : PokemonInstance
	{
		#region Salazzle Constructors
		/// <summary>
		/// Salazzle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Salazzle(string nickname, int level)
		: base(
				SalazzleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salazzle Constructor only waiting for a Level
		/// </summary>
		public Salazzle(int level)
		: this( "Salazzle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salazzle Constructor waiting for no params
		/// </summary>
		/*
		public Salazzle() : this( "Salazzle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}