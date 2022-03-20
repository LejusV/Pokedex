using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cacnea PokemonInstance Class
	#region Cacnea
	public class Cacnea : PokemonInstance
	{
		#region Cacnea Constructors
		/// <summary>
		/// Cacnea Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cacnea(string nickname, int level)
		: base(
				CacneaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacnea Constructor only waiting for a Level
		/// </summary>
		public Cacnea(int level)
		: this( "Cacnea", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacnea Constructor waiting for no params
		/// </summary>
		/*
		public Cacnea() : this( "Cacnea", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}