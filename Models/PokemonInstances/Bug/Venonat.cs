using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Venonat PokemonInstance Class
	#region Venonat
	public class Venonat : PokemonInstance
	{
		#region Venonat Constructors
		/// <summary>
		/// Venonat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Venonat(string nickname, int level)
		: base(
				VenonatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venonat Constructor only waiting for a Level
		/// </summary>
		public Venonat(int level)
		: this( "Venonat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venonat Constructor waiting for no params
		/// </summary>
		/*
		public Venonat() : this( "Venonat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}