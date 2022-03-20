using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Turtwig PokemonInstance Class
	#region Turtwig
	public class Turtwig : PokemonInstance
	{
		#region Turtwig Constructors
		/// <summary>
		/// Turtwig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Turtwig(string nickname, int level)
		: base(
				TurtwigSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtwig Constructor only waiting for a Level
		/// </summary>
		public Turtwig(int level)
		: this( "Turtwig", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtwig Constructor waiting for no params
		/// </summary>
		/*
		public Turtwig() : this( "Turtwig", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}