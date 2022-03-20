using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gliscor PokemonInstance Class
	#region Gliscor
	public class Gliscor : PokemonInstance
	{
		#region Gliscor Constructors
		/// <summary>
		/// Gliscor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gliscor(string nickname, int level)
		: base(
				GliscorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gliscor Constructor only waiting for a Level
		/// </summary>
		public Gliscor(int level)
		: this( "Gliscor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gliscor Constructor waiting for no params
		/// </summary>
		/*
		public Gliscor() : this( "Gliscor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}