using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gigalith PokemonInstance Class
	#region Gigalith
	public class Gigalith : PokemonInstance
	{
		#region Gigalith Constructors
		/// <summary>
		/// Gigalith Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gigalith(string nickname, int level)
		: base(
				GigalithSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gigalith Constructor only waiting for a Level
		/// </summary>
		public Gigalith(int level)
		: this( "Gigalith", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gigalith Constructor waiting for no params
		/// </summary>
		/*
		public Gigalith() : this( "Gigalith", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}