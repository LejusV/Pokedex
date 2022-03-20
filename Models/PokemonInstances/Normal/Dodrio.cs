using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dodrio PokemonInstance Class
	#region Dodrio
	public class Dodrio : PokemonInstance
	{
		#region Dodrio Constructors
		/// <summary>
		/// Dodrio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dodrio(string nickname, int level)
		: base(
				DodrioSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dodrio Constructor only waiting for a Level
		/// </summary>
		public Dodrio(int level)
		: this( "Dodrio", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dodrio Constructor waiting for no params
		/// </summary>
		/*
		public Dodrio() : this( "Dodrio", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}