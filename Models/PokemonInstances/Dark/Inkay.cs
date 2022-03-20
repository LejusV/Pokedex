using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Inkay PokemonInstance Class
	#region Inkay
	public class Inkay : PokemonInstance
	{
		#region Inkay Constructors
		/// <summary>
		/// Inkay Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Inkay(string nickname, int level)
		: base(
				InkaySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inkay Constructor only waiting for a Level
		/// </summary>
		public Inkay(int level)
		: this( "Inkay", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inkay Constructor waiting for no params
		/// </summary>
		/*
		public Inkay() : this( "Inkay", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}