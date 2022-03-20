using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rhyperior PokemonInstance Class
	#region Rhyperior
	public class Rhyperior : PokemonInstance
	{
		#region Rhyperior Constructors
		/// <summary>
		/// Rhyperior Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rhyperior(string nickname, int level)
		: base(
				RhyperiorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyperior Constructor only waiting for a Level
		/// </summary>
		public Rhyperior(int level)
		: this( "Rhyperior", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyperior Constructor waiting for no params
		/// </summary>
		/*
		public Rhyperior() : this( "Rhyperior", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}