using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Starly PokemonInstance Class
	#region Starly
	public class Starly : PokemonInstance
	{
		#region Starly Constructors
		/// <summary>
		/// Starly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Starly(string nickname, int level)
		: base(
				StarlySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starly Constructor only waiting for a Level
		/// </summary>
		public Starly(int level)
		: this( "Starly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starly Constructor waiting for no params
		/// </summary>
		/*
		public Starly() : this( "Starly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}