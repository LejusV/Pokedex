using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Paras PokemonInstance Class
	#region Paras
	public class Paras : PokemonInstance
	{
		#region Paras Constructors
		/// <summary>
		/// Paras Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Paras(string nickname, int level)
		: base(
				ParasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Paras Constructor only waiting for a Level
		/// </summary>
		public Paras(int level)
		: this( "Paras", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Paras Constructor waiting for no params
		/// </summary>
		/*
		public Paras() : this( "Paras", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}