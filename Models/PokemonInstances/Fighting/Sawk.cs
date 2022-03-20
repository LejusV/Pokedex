using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sawk PokemonInstance Class
	#region Sawk
	public class Sawk : PokemonInstance
	{
		#region Sawk Constructors
		/// <summary>
		/// Sawk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sawk(string nickname, int level)
		: base(
				SawkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawk Constructor only waiting for a Level
		/// </summary>
		public Sawk(int level)
		: this( "Sawk", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawk Constructor waiting for no params
		/// </summary>
		/*
		public Sawk() : this( "Sawk", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}