using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bidoof PokemonInstance Class
	#region Bidoof
	public class Bidoof : PokemonInstance
	{
		#region Bidoof Constructors
		/// <summary>
		/// Bidoof Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bidoof(string nickname, int level)
		: base(
				BidoofSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bidoof Constructor only waiting for a Level
		/// </summary>
		public Bidoof(int level)
		: this( "Bidoof", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bidoof Constructor waiting for no params
		/// </summary>
		/*
		public Bidoof() : this( "Bidoof", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}