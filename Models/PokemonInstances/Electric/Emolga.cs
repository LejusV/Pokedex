using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Emolga PokemonInstance Class
	#region Emolga
	public class Emolga : PokemonInstance
	{
		#region Emolga Constructors
		/// <summary>
		/// Emolga Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Emolga(string nickname, int level)
		: base(
				EmolgaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emolga Constructor only waiting for a Level
		/// </summary>
		public Emolga(int level)
		: this( "Emolga", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emolga Constructor waiting for no params
		/// </summary>
		/*
		public Emolga() : this( "Emolga", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}