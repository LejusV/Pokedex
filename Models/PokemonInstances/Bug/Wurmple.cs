using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wurmple PokemonInstance Class
	#region Wurmple
	public class Wurmple : PokemonInstance
	{
		#region Wurmple Constructors
		/// <summary>
		/// Wurmple Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wurmple(string nickname, int level)
		: base(
				WurmpleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wurmple Constructor only waiting for a Level
		/// </summary>
		public Wurmple(int level)
		: this( "Wurmple", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wurmple Constructor waiting for no params
		/// </summary>
		/*
		public Wurmple() : this( "Wurmple", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}