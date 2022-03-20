using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Whimsicott PokemonInstance Class
	#region Whimsicott
	public class Whimsicott : PokemonInstance
	{
		#region Whimsicott Constructors
		/// <summary>
		/// Whimsicott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Whimsicott(string nickname, int level)
		: base(
				WhimsicottSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whimsicott Constructor only waiting for a Level
		/// </summary>
		public Whimsicott(int level)
		: this( "Whimsicott", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whimsicott Constructor waiting for no params
		/// </summary>
		/*
		public Whimsicott() : this( "Whimsicott", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}