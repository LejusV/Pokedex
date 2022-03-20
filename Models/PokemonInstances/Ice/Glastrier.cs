using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Glastrier PokemonInstance Class
	#region Glastrier
	public class Glastrier : PokemonInstance
	{
		#region Glastrier Constructors
		/// <summary>
		/// Glastrier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Glastrier(string nickname, int level)
		: base(
				GlastrierSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glastrier Constructor only waiting for a Level
		/// </summary>
		public Glastrier(int level)
		: this( "Glastrier", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glastrier Constructor waiting for no params
		/// </summary>
		/*
		public Glastrier() : this( "Glastrier", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}