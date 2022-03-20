using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Metang PokemonInstance Class
	#region Metang
	public class Metang : PokemonInstance
	{
		#region Metang Constructors
		/// <summary>
		/// Metang Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Metang(string nickname, int level)
		: base(
				MetangSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metang Constructor only waiting for a Level
		/// </summary>
		public Metang(int level)
		: this( "Metang", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metang Constructor waiting for no params
		/// </summary>
		/*
		public Metang() : this( "Metang", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}