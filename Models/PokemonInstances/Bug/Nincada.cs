using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nincada PokemonInstance Class
	#region Nincada
	public class Nincada : PokemonInstance
	{
		#region Nincada Constructors
		/// <summary>
		/// Nincada Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nincada(string nickname, int level)
		: base(
				NincadaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nincada Constructor only waiting for a Level
		/// </summary>
		public Nincada(int level)
		: this( "Nincada", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nincada Constructor waiting for no params
		/// </summary>
		/*
		public Nincada() : this( "Nincada", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}