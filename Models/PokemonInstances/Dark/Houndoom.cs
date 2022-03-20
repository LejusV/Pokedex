using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Houndoom PokemonInstance Class
	#region Houndoom
	public class Houndoom : PokemonInstance
	{
		#region Houndoom Constructors
		/// <summary>
		/// Houndoom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Houndoom(string nickname, int level)
		: base(
				HoundoomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndoom Constructor only waiting for a Level
		/// </summary>
		public Houndoom(int level)
		: this( "Houndoom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndoom Constructor waiting for no params
		/// </summary>
		/*
		public Houndoom() : this( "Houndoom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}