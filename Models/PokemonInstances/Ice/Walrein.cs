using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Walrein PokemonInstance Class
	#region Walrein
	public class Walrein : PokemonInstance
	{
		#region Walrein Constructors
		/// <summary>
		/// Walrein Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Walrein(string nickname, int level)
		: base(
				WalreinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Walrein Constructor only waiting for a Level
		/// </summary>
		public Walrein(int level)
		: this( "Walrein", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Walrein Constructor waiting for no params
		/// </summary>
		/*
		public Walrein() : this( "Walrein", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}