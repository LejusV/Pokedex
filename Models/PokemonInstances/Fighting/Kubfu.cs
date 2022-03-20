using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kubfu PokemonInstance Class
	#region Kubfu
	public class Kubfu : PokemonInstance
	{
		#region Kubfu Constructors
		/// <summary>
		/// Kubfu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kubfu(string nickname, int level)
		: base(
				KubfuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kubfu Constructor only waiting for a Level
		/// </summary>
		public Kubfu(int level)
		: this( "Kubfu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kubfu Constructor waiting for no params
		/// </summary>
		/*
		public Kubfu() : this( "Kubfu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}