using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Corvisquire PokemonInstance Class
	#region Corvisquire
	public class Corvisquire : PokemonInstance
	{
		#region Corvisquire Constructors
		/// <summary>
		/// Corvisquire Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Corvisquire(string nickname, int level)
		: base(
				CorvisquireSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corvisquire Constructor only waiting for a Level
		/// </summary>
		public Corvisquire(int level)
		: this( "Corvisquire", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corvisquire Constructor waiting for no params
		/// </summary>
		/*
		public Corvisquire() : this( "Corvisquire", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}