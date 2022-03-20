using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lapras PokemonInstance Class
	#region Lapras
	public class Lapras : PokemonInstance
	{
		#region Lapras Constructors
		/// <summary>
		/// Lapras Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lapras(string nickname, int level)
		: base(
				LaprasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lapras Constructor only waiting for a Level
		/// </summary>
		public Lapras(int level)
		: this( "Lapras", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lapras Constructor waiting for no params
		/// </summary>
		/*
		public Lapras() : this( "Lapras", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}