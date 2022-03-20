using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Toxicroak PokemonInstance Class
	#region Toxicroak
	public class Toxicroak : PokemonInstance
	{
		#region Toxicroak Constructors
		/// <summary>
		/// Toxicroak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Toxicroak(string nickname, int level)
		: base(
				ToxicroakSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxicroak Constructor only waiting for a Level
		/// </summary>
		public Toxicroak(int level)
		: this( "Toxicroak", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxicroak Constructor waiting for no params
		/// </summary>
		/*
		public Toxicroak() : this( "Toxicroak", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}