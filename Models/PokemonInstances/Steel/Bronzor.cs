using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bronzor PokemonInstance Class
	#region Bronzor
	public class Bronzor : PokemonInstance
	{
		#region Bronzor Constructors
		/// <summary>
		/// Bronzor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bronzor(string nickname, int level)
		: base(
				BronzorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzor Constructor only waiting for a Level
		/// </summary>
		public Bronzor(int level)
		: this( "Bronzor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzor Constructor waiting for no params
		/// </summary>
		/*
		public Bronzor() : this( "Bronzor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}