using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chatot PokemonInstance Class
	#region Chatot
	public class Chatot : PokemonInstance
	{
		#region Chatot Constructors
		/// <summary>
		/// Chatot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chatot(string nickname, int level)
		: base(
				ChatotSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chatot Constructor only waiting for a Level
		/// </summary>
		public Chatot(int level)
		: this( "Chatot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chatot Constructor waiting for no params
		/// </summary>
		/*
		public Chatot() : this( "Chatot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}