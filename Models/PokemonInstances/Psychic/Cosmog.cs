using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cosmog PokemonInstance Class
	#region Cosmog
	public class Cosmog : PokemonInstance
	{
		#region Cosmog Constructors
		/// <summary>
		/// Cosmog Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cosmog(string nickname, int level)
		: base(
				CosmogSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmog Constructor only waiting for a Level
		/// </summary>
		public Cosmog(int level)
		: this( "Cosmog", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmog Constructor waiting for no params
		/// </summary>
		/*
		public Cosmog() : this( "Cosmog", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}