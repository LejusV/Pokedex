using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Doublade PokemonInstance Class
	#region Doublade
	public class Doublade : PokemonInstance
	{
		#region Doublade Constructors
		/// <summary>
		/// Doublade Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Doublade(string nickname, int level)
		: base(
				DoubladeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doublade Constructor only waiting for a Level
		/// </summary>
		public Doublade(int level)
		: this( "Doublade", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doublade Constructor waiting for no params
		/// </summary>
		/*
		public Doublade() : this( "Doublade", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}