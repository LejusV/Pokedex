using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Clefairy PokemonInstance Class
	#region Clefairy
	public class Clefairy : PokemonInstance
	{
		#region Clefairy Constructors
		/// <summary>
		/// Clefairy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Clefairy(string nickname, int level)
		: base(
				ClefairySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefairy Constructor only waiting for a Level
		/// </summary>
		public Clefairy(int level)
		: this( "Clefairy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefairy Constructor waiting for no params
		/// </summary>
		/*
		public Clefairy() : this( "Clefairy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}