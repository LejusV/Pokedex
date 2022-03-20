using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magmar PokemonInstance Class
	#region Magmar
	public class Magmar : PokemonInstance
	{
		#region Magmar Constructors
		/// <summary>
		/// Magmar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magmar(string nickname, int level)
		: base(
				MagmarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmar Constructor only waiting for a Level
		/// </summary>
		public Magmar(int level)
		: this( "Magmar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmar Constructor waiting for no params
		/// </summary>
		/*
		public Magmar() : this( "Magmar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}