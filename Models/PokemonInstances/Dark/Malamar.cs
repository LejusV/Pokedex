using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Malamar PokemonInstance Class
	#region Malamar
	public class Malamar : PokemonInstance
	{
		#region Malamar Constructors
		/// <summary>
		/// Malamar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Malamar(string nickname, int level)
		: base(
				MalamarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Malamar Constructor only waiting for a Level
		/// </summary>
		public Malamar(int level)
		: this( "Malamar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Malamar Constructor waiting for no params
		/// </summary>
		/*
		public Malamar() : this( "Malamar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}