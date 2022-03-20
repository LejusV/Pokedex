using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Barbaracle PokemonInstance Class
	#region Barbaracle
	public class Barbaracle : PokemonInstance
	{
		#region Barbaracle Constructors
		/// <summary>
		/// Barbaracle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Barbaracle(string nickname, int level)
		: base(
				BarbaracleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barbaracle Constructor only waiting for a Level
		/// </summary>
		public Barbaracle(int level)
		: this( "Barbaracle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barbaracle Constructor waiting for no params
		/// </summary>
		/*
		public Barbaracle() : this( "Barbaracle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}