using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rapidash PokemonInstance Class
	#region Rapidash
	public class Rapidash : PokemonInstance
	{
		#region Rapidash Constructors
		/// <summary>
		/// Rapidash Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rapidash(string nickname, int level)
		: base(
				RapidashSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rapidash Constructor only waiting for a Level
		/// </summary>
		public Rapidash(int level)
		: this( "Rapidash", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rapidash Constructor waiting for no params
		/// </summary>
		/*
		public Rapidash() : this( "Rapidash", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}