using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Comfey PokemonInstance Class
	#region Comfey
	public class Comfey : PokemonInstance
	{
		#region Comfey Constructors
		/// <summary>
		/// Comfey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Comfey(string nickname, int level)
		: base(
				ComfeySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Comfey Constructor only waiting for a Level
		/// </summary>
		public Comfey(int level)
		: this( "Comfey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Comfey Constructor waiting for no params
		/// </summary>
		/*
		public Comfey() : this( "Comfey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}