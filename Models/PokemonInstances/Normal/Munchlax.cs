using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Munchlax PokemonInstance Class
	#region Munchlax
	public class Munchlax : PokemonInstance
	{
		#region Munchlax Constructors
		/// <summary>
		/// Munchlax Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Munchlax(string nickname, int level)
		: base(
				MunchlaxSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munchlax Constructor only waiting for a Level
		/// </summary>
		public Munchlax(int level)
		: this( "Munchlax", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munchlax Constructor waiting for no params
		/// </summary>
		/*
		public Munchlax() : this( "Munchlax", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}