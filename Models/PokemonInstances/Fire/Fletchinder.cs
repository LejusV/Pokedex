using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Fletchinder PokemonInstance Class
	#region Fletchinder
	public class Fletchinder : PokemonInstance
	{
		#region Fletchinder Constructors
		/// <summary>
		/// Fletchinder Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Fletchinder(string nickname, int level)
		: base(
				FletchinderSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchinder Constructor only waiting for a Level
		/// </summary>
		public Fletchinder(int level)
		: this( "Fletchinder", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchinder Constructor waiting for no params
		/// </summary>
		/*
		public Fletchinder() : this( "Fletchinder", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}