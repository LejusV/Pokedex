using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wooper PokemonInstance Class
	#region Wooper
	public class Wooper : PokemonInstance
	{
		#region Wooper Constructors
		/// <summary>
		/// Wooper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wooper(string nickname, int level)
		: base(
				WooperSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooper Constructor only waiting for a Level
		/// </summary>
		public Wooper(int level)
		: this( "Wooper", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooper Constructor waiting for no params
		/// </summary>
		/*
		public Wooper() : this( "Wooper", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}