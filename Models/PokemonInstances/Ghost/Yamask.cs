using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Yamask PokemonInstance Class
	#region Yamask
	public class Yamask : PokemonInstance
	{
		#region Yamask Constructors
		/// <summary>
		/// Yamask Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Yamask(string nickname, int level)
		: base(
				YamaskSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamask Constructor only waiting for a Level
		/// </summary>
		public Yamask(int level)
		: this( "Yamask", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamask Constructor waiting for no params
		/// </summary>
		/*
		public Yamask() : this( "Yamask", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}