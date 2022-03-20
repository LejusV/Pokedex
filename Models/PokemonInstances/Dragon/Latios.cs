using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Latios PokemonInstance Class
	#region Latios
	public class Latios : PokemonInstance
	{
		#region Latios Constructors
		/// <summary>
		/// Latios Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Latios(string nickname, int level)
		: base(
				LatiosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latios Constructor only waiting for a Level
		/// </summary>
		public Latios(int level)
		: this( "Latios", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latios Constructor waiting for no params
		/// </summary>
		/*
		public Latios() : this( "Latios", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}