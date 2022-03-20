using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magnemite PokemonInstance Class
	#region Magnemite
	public class Magnemite : PokemonInstance
	{
		#region Magnemite Constructors
		/// <summary>
		/// Magnemite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magnemite(string nickname, int level)
		: base(
				MagnemiteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnemite Constructor only waiting for a Level
		/// </summary>
		public Magnemite(int level)
		: this( "Magnemite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnemite Constructor waiting for no params
		/// </summary>
		/*
		public Magnemite() : this( "Magnemite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}