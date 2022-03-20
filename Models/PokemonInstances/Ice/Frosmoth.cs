using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Frosmoth PokemonInstance Class
	#region Frosmoth
	public class Frosmoth : PokemonInstance
	{
		#region Frosmoth Constructors
		/// <summary>
		/// Frosmoth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Frosmoth(string nickname, int level)
		: base(
				FrosmothSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frosmoth Constructor only waiting for a Level
		/// </summary>
		public Frosmoth(int level)
		: this( "Frosmoth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frosmoth Constructor waiting for no params
		/// </summary>
		/*
		public Frosmoth() : this( "Frosmoth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}