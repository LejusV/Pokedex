using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Necrozma PokemonInstance Class
	#region Necrozma
	public class Necrozma : PokemonInstance
	{
		#region Necrozma Constructors
		/// <summary>
		/// Necrozma Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Necrozma(string nickname, int level)
		: base(
				NecrozmaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Necrozma Constructor only waiting for a Level
		/// </summary>
		public Necrozma(int level)
		: this( "Necrozma", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Necrozma Constructor waiting for no params
		/// </summary>
		/*
		public Necrozma() : this( "Necrozma", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}