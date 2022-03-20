using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Glameow PokemonInstance Class
	#region Glameow
	public class Glameow : PokemonInstance
	{
		#region Glameow Constructors
		/// <summary>
		/// Glameow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Glameow(string nickname, int level)
		: base(
				GlameowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glameow Constructor only waiting for a Level
		/// </summary>
		public Glameow(int level)
		: this( "Glameow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glameow Constructor waiting for no params
		/// </summary>
		/*
		public Glameow() : this( "Glameow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}