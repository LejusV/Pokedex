using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tranquill PokemonInstance Class
	#region Tranquill
	public class Tranquill : PokemonInstance
	{
		#region Tranquill Constructors
		/// <summary>
		/// Tranquill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tranquill(string nickname, int level)
		: base(
				TranquillSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tranquill Constructor only waiting for a Level
		/// </summary>
		public Tranquill(int level)
		: this( "Tranquill", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tranquill Constructor waiting for no params
		/// </summary>
		/*
		public Tranquill() : this( "Tranquill", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}