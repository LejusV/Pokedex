using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drapion PokemonInstance Class
	#region Drapion
	public class Drapion : PokemonInstance
	{
		#region Drapion Constructors
		/// <summary>
		/// Drapion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drapion(string nickname, int level)
		: base(
				DrapionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drapion Constructor only waiting for a Level
		/// </summary>
		public Drapion(int level)
		: this( "Drapion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drapion Constructor waiting for no params
		/// </summary>
		/*
		public Drapion() : this( "Drapion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}