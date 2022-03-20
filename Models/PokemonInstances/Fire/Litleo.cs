using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Litleo PokemonInstance Class
	#region Litleo
	public class Litleo : PokemonInstance
	{
		#region Litleo Constructors
		/// <summary>
		/// Litleo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Litleo(string nickname, int level)
		: base(
				LitleoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litleo Constructor only waiting for a Level
		/// </summary>
		public Litleo(int level)
		: this( "Litleo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litleo Constructor waiting for no params
		/// </summary>
		/*
		public Litleo() : this( "Litleo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}