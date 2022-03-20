using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drilbur PokemonInstance Class
	#region Drilbur
	public class Drilbur : PokemonInstance
	{
		#region Drilbur Constructors
		/// <summary>
		/// Drilbur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drilbur(string nickname, int level)
		: base(
				DrilburSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drilbur Constructor only waiting for a Level
		/// </summary>
		public Drilbur(int level)
		: this( "Drilbur", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drilbur Constructor waiting for no params
		/// </summary>
		/*
		public Drilbur() : this( "Drilbur", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}