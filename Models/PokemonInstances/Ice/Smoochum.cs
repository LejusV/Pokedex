using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Smoochum PokemonInstance Class
	#region Smoochum
	public class Smoochum : PokemonInstance
	{
		#region Smoochum Constructors
		/// <summary>
		/// Smoochum Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Smoochum(string nickname, int level)
		: base(
				SmoochumSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smoochum Constructor only waiting for a Level
		/// </summary>
		public Smoochum(int level)
		: this( "Smoochum", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smoochum Constructor waiting for no params
		/// </summary>
		/*
		public Smoochum() : this( "Smoochum", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}