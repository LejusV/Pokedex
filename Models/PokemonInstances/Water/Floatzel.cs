using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Floatzel PokemonInstance Class
	#region Floatzel
	public class Floatzel : PokemonInstance
	{
		#region Floatzel Constructors
		/// <summary>
		/// Floatzel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Floatzel(string nickname, int level)
		: base(
				FloatzelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floatzel Constructor only waiting for a Level
		/// </summary>
		public Floatzel(int level)
		: this( "Floatzel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floatzel Constructor waiting for no params
		/// </summary>
		/*
		public Floatzel() : this( "Floatzel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}