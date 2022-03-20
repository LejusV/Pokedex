using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spiritomb PokemonInstance Class
	#region Spiritomb
	public class Spiritomb : PokemonInstance
	{
		#region Spiritomb Constructors
		/// <summary>
		/// Spiritomb Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spiritomb(string nickname, int level)
		: base(
				SpiritombSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spiritomb Constructor only waiting for a Level
		/// </summary>
		public Spiritomb(int level)
		: this( "Spiritomb", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spiritomb Constructor waiting for no params
		/// </summary>
		/*
		public Spiritomb() : this( "Spiritomb", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}