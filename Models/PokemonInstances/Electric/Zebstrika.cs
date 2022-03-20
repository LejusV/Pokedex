using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zebstrika PokemonInstance Class
	#region Zebstrika
	public class Zebstrika : PokemonInstance
	{
		#region Zebstrika Constructors
		/// <summary>
		/// Zebstrika Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zebstrika(string nickname, int level)
		: base(
				ZebstrikaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zebstrika Constructor only waiting for a Level
		/// </summary>
		public Zebstrika(int level)
		: this( "Zebstrika", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zebstrika Constructor waiting for no params
		/// </summary>
		/*
		public Zebstrika() : this( "Zebstrika", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}