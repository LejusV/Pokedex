using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Milotic PokemonInstance Class
	#region Milotic
	public class Milotic : PokemonInstance
	{
		#region Milotic Constructors
		/// <summary>
		/// Milotic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Milotic(string nickname, int level)
		: base(
				MiloticSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milotic Constructor only waiting for a Level
		/// </summary>
		public Milotic(int level)
		: this( "Milotic", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milotic Constructor waiting for no params
		/// </summary>
		/*
		public Milotic() : this( "Milotic", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}