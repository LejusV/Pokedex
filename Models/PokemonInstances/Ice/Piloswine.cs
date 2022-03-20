using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Piloswine PokemonInstance Class
	#region Piloswine
	public class Piloswine : PokemonInstance
	{
		#region Piloswine Constructors
		/// <summary>
		/// Piloswine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Piloswine(string nickname, int level)
		: base(
				PiloswineSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piloswine Constructor only waiting for a Level
		/// </summary>
		public Piloswine(int level)
		: this( "Piloswine", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piloswine Constructor waiting for no params
		/// </summary>
		/*
		public Piloswine() : this( "Piloswine", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}