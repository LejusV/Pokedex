using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Forretress PokemonInstance Class
	#region Forretress
	public class Forretress : PokemonInstance
	{
		#region Forretress Constructors
		/// <summary>
		/// Forretress Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Forretress(string nickname, int level)
		: base(
				ForretressSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Forretress Constructor only waiting for a Level
		/// </summary>
		public Forretress(int level)
		: this( "Forretress", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Forretress Constructor waiting for no params
		/// </summary>
		/*
		public Forretress() : this( "Forretress", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}