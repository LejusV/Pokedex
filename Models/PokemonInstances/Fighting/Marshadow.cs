using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Marshadow PokemonInstance Class
	#region Marshadow
	public class Marshadow : PokemonInstance
	{
		#region Marshadow Constructors
		/// <summary>
		/// Marshadow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Marshadow(string nickname, int level)
		: base(
				MarshadowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshadow Constructor only waiting for a Level
		/// </summary>
		public Marshadow(int level)
		: this( "Marshadow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshadow Constructor waiting for no params
		/// </summary>
		/*
		public Marshadow() : this( "Marshadow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}