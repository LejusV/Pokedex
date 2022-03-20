using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Whirlipede PokemonInstance Class
	#region Whirlipede
	public class Whirlipede : PokemonInstance
	{
		#region Whirlipede Constructors
		/// <summary>
		/// Whirlipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Whirlipede(string nickname, int level)
		: base(
				WhirlipedeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whirlipede Constructor only waiting for a Level
		/// </summary>
		public Whirlipede(int level)
		: this( "Whirlipede", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whirlipede Constructor waiting for no params
		/// </summary>
		/*
		public Whirlipede() : this( "Whirlipede", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}