using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wishiwashi-Solo PokemonInstance Class
	#region Wishiwashi-Solo
	public class WishiwashiSolo : PokemonInstance
	{
		#region Wishiwashi-Solo Constructors
		/// <summary>
		/// Wishiwashi-Solo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WishiwashiSolo(string nickname, int level)
		: base(
				WishiwashiSoloSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wishiwashi-Solo Constructor only waiting for a Level
		/// </summary>
		public WishiwashiSolo(int level)
		: this( "Wishiwashi-Solo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wishiwashi-Solo Constructor waiting for no params
		/// </summary>
		/*
		public WishiwashiSolo() : this( "Wishiwashi-Solo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}