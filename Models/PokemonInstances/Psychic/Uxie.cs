using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Uxie PokemonInstance Class
	#region Uxie
	public class Uxie : PokemonInstance
	{
		#region Uxie Constructors
		/// <summary>
		/// Uxie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Uxie(string nickname, int level)
		: base(
				UxieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Uxie Constructor only waiting for a Level
		/// </summary>
		public Uxie(int level)
		: this( "Uxie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Uxie Constructor waiting for no params
		/// </summary>
		/*
		public Uxie() : this( "Uxie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}