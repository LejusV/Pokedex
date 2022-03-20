using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spoink PokemonInstance Class
	#region Spoink
	public class Spoink : PokemonInstance
	{
		#region Spoink Constructors
		/// <summary>
		/// Spoink Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spoink(string nickname, int level)
		: base(
				SpoinkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spoink Constructor only waiting for a Level
		/// </summary>
		public Spoink(int level)
		: this( "Spoink", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spoink Constructor waiting for no params
		/// </summary>
		/*
		public Spoink() : this( "Spoink", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}