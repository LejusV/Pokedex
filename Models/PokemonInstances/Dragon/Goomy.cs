using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Goomy PokemonInstance Class
	#region Goomy
	public class Goomy : PokemonInstance
	{
		#region Goomy Constructors
		/// <summary>
		/// Goomy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Goomy(string nickname, int level)
		: base(
				GoomySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goomy Constructor only waiting for a Level
		/// </summary>
		public Goomy(int level)
		: this( "Goomy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goomy Constructor waiting for no params
		/// </summary>
		/*
		public Goomy() : this( "Goomy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}