using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dottler PokemonInstance Class
	#region Dottler
	public class Dottler : PokemonInstance
	{
		#region Dottler Constructors
		/// <summary>
		/// Dottler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dottler(string nickname, int level)
		: base(
				DottlerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dottler Constructor only waiting for a Level
		/// </summary>
		public Dottler(int level)
		: this( "Dottler", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dottler Constructor waiting for no params
		/// </summary>
		/*
		public Dottler() : this( "Dottler", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}