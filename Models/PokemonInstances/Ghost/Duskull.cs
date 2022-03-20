using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Duskull PokemonInstance Class
	#region Duskull
	public class Duskull : PokemonInstance
	{
		#region Duskull Constructors
		/// <summary>
		/// Duskull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Duskull(string nickname, int level)
		: base(
				DuskullSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duskull Constructor only waiting for a Level
		/// </summary>
		public Duskull(int level)
		: this( "Duskull", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duskull Constructor waiting for no params
		/// </summary>
		/*
		public Duskull() : this( "Duskull", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}