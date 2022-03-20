using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Quagsire PokemonInstance Class
	#region Quagsire
	public class Quagsire : PokemonInstance
	{
		#region Quagsire Constructors
		/// <summary>
		/// Quagsire Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Quagsire(string nickname, int level)
		: base(
				QuagsireSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quagsire Constructor only waiting for a Level
		/// </summary>
		public Quagsire(int level)
		: this( "Quagsire", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quagsire Constructor waiting for no params
		/// </summary>
		/*
		public Quagsire() : this( "Quagsire", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}