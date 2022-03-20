using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magby PokemonInstance Class
	#region Magby
	public class Magby : PokemonInstance
	{
		#region Magby Constructors
		/// <summary>
		/// Magby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magby(string nickname, int level)
		: base(
				MagbySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magby Constructor only waiting for a Level
		/// </summary>
		public Magby(int level)
		: this( "Magby", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magby Constructor waiting for no params
		/// </summary>
		/*
		public Magby() : this( "Magby", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}