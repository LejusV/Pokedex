using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cyndaquil PokemonInstance Class
	#region Cyndaquil
	public class Cyndaquil : PokemonInstance
	{
		#region Cyndaquil Constructors
		/// <summary>
		/// Cyndaquil Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cyndaquil(string nickname, int level)
		: base(
				CyndaquilSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cyndaquil Constructor only waiting for a Level
		/// </summary>
		public Cyndaquil(int level)
		: this( "Cyndaquil", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cyndaquil Constructor waiting for no params
		/// </summary>
		/*
		public Cyndaquil() : this( "Cyndaquil", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}