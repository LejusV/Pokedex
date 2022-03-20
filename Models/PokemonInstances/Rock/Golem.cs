using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Golem PokemonInstance Class
	#region Golem
	public class Golem : PokemonInstance
	{
		#region Golem Constructors
		/// <summary>
		/// Golem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Golem(string nickname, int level)
		: base(
				GolemSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golem Constructor only waiting for a Level
		/// </summary>
		public Golem(int level)
		: this( "Golem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golem Constructor waiting for no params
		/// </summary>
		/*
		public Golem() : this( "Golem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}