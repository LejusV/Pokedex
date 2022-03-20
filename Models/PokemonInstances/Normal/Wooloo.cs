using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wooloo PokemonInstance Class
	#region Wooloo
	public class Wooloo : PokemonInstance
	{
		#region Wooloo Constructors
		/// <summary>
		/// Wooloo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wooloo(string nickname, int level)
		: base(
				WoolooSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooloo Constructor only waiting for a Level
		/// </summary>
		public Wooloo(int level)
		: this( "Wooloo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooloo Constructor waiting for no params
		/// </summary>
		/*
		public Wooloo() : this( "Wooloo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}