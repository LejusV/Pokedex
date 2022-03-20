using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Marowak PokemonInstance Class
	#region Marowak
	public class Marowak : PokemonInstance
	{
		#region Marowak Constructors
		/// <summary>
		/// Marowak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Marowak(string nickname, int level)
		: base(
				MarowakSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marowak Constructor only waiting for a Level
		/// </summary>
		public Marowak(int level)
		: this( "Marowak", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marowak Constructor waiting for no params
		/// </summary>
		/*
		public Marowak() : this( "Marowak", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}