using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Horsea PokemonInstance Class
	#region Horsea
	public class Horsea : PokemonInstance
	{
		#region Horsea Constructors
		/// <summary>
		/// Horsea Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Horsea(string nickname, int level)
		: base(
				HorseaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Horsea Constructor only waiting for a Level
		/// </summary>
		public Horsea(int level)
		: this( "Horsea", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Horsea Constructor waiting for no params
		/// </summary>
		/*
		public Horsea() : this( "Horsea", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}