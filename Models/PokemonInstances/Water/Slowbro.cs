using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slowbro PokemonInstance Class
	#region Slowbro
	public class Slowbro : PokemonInstance
	{
		#region Slowbro Constructors
		/// <summary>
		/// Slowbro Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slowbro(string nickname, int level)
		: base(
				SlowbroSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowbro Constructor only waiting for a Level
		/// </summary>
		public Slowbro(int level)
		: this( "Slowbro", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowbro Constructor waiting for no params
		/// </summary>
		/*
		public Slowbro() : this( "Slowbro", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}