using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gloom PokemonInstance Class
	#region Gloom
	public class Gloom : PokemonInstance
	{
		#region Gloom Constructors
		/// <summary>
		/// Gloom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gloom(string nickname, int level)
		: base(
				GloomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gloom Constructor only waiting for a Level
		/// </summary>
		public Gloom(int level)
		: this( "Gloom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gloom Constructor waiting for no params
		/// </summary>
		/*
		public Gloom() : this( "Gloom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}