using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Persian PokemonInstance Class
	#region Persian
	public class Persian : PokemonInstance
	{
		#region Persian Constructors
		/// <summary>
		/// Persian Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Persian(string nickname, int level)
		: base(
				PersianSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Persian Constructor only waiting for a Level
		/// </summary>
		public Persian(int level)
		: this( "Persian", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Persian Constructor waiting for no params
		/// </summary>
		/*
		public Persian() : this( "Persian", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}