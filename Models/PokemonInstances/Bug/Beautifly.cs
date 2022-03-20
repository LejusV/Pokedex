using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Beautifly PokemonInstance Class
	#region Beautifly
	public class Beautifly : PokemonInstance
	{
		#region Beautifly Constructors
		/// <summary>
		/// Beautifly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Beautifly(string nickname, int level)
		: base(
				BeautiflySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beautifly Constructor only waiting for a Level
		/// </summary>
		public Beautifly(int level)
		: this( "Beautifly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beautifly Constructor waiting for no params
		/// </summary>
		/*
		public Beautifly() : this( "Beautifly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}