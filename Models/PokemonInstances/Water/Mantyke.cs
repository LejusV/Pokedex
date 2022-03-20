using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mantyke PokemonInstance Class
	#region Mantyke
	public class Mantyke : PokemonInstance
	{
		#region Mantyke Constructors
		/// <summary>
		/// Mantyke Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mantyke(string nickname, int level)
		: base(
				MantykeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantyke Constructor only waiting for a Level
		/// </summary>
		public Mantyke(int level)
		: this( "Mantyke", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantyke Constructor waiting for no params
		/// </summary>
		/*
		public Mantyke() : this( "Mantyke", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}