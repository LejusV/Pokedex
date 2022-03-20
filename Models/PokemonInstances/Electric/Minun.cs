using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Minun PokemonInstance Class
	#region Minun
	public class Minun : PokemonInstance
	{
		#region Minun Constructors
		/// <summary>
		/// Minun Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Minun(string nickname, int level)
		: base(
				MinunSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minun Constructor only waiting for a Level
		/// </summary>
		public Minun(int level)
		: this( "Minun", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minun Constructor waiting for no params
		/// </summary>
		/*
		public Minun() : this( "Minun", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}