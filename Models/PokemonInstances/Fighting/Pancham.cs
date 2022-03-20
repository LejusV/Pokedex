using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pancham PokemonInstance Class
	#region Pancham
	public class Pancham : PokemonInstance
	{
		#region Pancham Constructors
		/// <summary>
		/// Pancham Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pancham(string nickname, int level)
		: base(
				PanchamSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pancham Constructor only waiting for a Level
		/// </summary>
		public Pancham(int level)
		: this( "Pancham", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pancham Constructor waiting for no params
		/// </summary>
		/*
		public Pancham() : this( "Pancham", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}