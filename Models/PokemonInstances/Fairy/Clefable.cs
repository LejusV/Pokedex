using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Clefable PokemonInstance Class
	#region Clefable
	public class Clefable : PokemonInstance
	{
		#region Clefable Constructors
		/// <summary>
		/// Clefable Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Clefable(string nickname, int level)
		: base(
				ClefableSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefable Constructor only waiting for a Level
		/// </summary>
		public Clefable(int level)
		: this( "Clefable", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefable Constructor waiting for no params
		/// </summary>
		/*
		public Clefable() : this( "Clefable", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}