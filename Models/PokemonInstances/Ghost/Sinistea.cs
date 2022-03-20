using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sinistea PokemonInstance Class
	#region Sinistea
	public class Sinistea : PokemonInstance
	{
		#region Sinistea Constructors
		/// <summary>
		/// Sinistea Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sinistea(string nickname, int level)
		: base(
				SinisteaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sinistea Constructor only waiting for a Level
		/// </summary>
		public Sinistea(int level)
		: this( "Sinistea", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sinistea Constructor waiting for no params
		/// </summary>
		/*
		public Sinistea() : this( "Sinistea", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}