using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rhydon PokemonInstance Class
	#region Rhydon
	public class Rhydon : PokemonInstance
	{
		#region Rhydon Constructors
		/// <summary>
		/// Rhydon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rhydon(string nickname, int level)
		: base(
				RhydonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhydon Constructor only waiting for a Level
		/// </summary>
		public Rhydon(int level)
		: this( "Rhydon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhydon Constructor waiting for no params
		/// </summary>
		/*
		public Rhydon() : this( "Rhydon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}