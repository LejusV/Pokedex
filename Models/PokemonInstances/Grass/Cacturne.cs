using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cacturne PokemonInstance Class
	#region Cacturne
	public class Cacturne : PokemonInstance
	{
		#region Cacturne Constructors
		/// <summary>
		/// Cacturne Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cacturne(string nickname, int level)
		: base(
				CacturneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacturne Constructor only waiting for a Level
		/// </summary>
		public Cacturne(int level)
		: this( "Cacturne", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacturne Constructor waiting for no params
		/// </summary>
		/*
		public Cacturne() : this( "Cacturne", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}