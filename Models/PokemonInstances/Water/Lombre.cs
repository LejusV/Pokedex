using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lombre PokemonInstance Class
	#region Lombre
	public class Lombre : PokemonInstance
	{
		#region Lombre Constructors
		/// <summary>
		/// Lombre Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lombre(string nickname, int level)
		: base(
				LombreSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lombre Constructor only waiting for a Level
		/// </summary>
		public Lombre(int level)
		: this( "Lombre", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lombre Constructor waiting for no params
		/// </summary>
		/*
		public Lombre() : this( "Lombre", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}