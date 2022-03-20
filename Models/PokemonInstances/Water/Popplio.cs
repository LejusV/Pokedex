using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Popplio PokemonInstance Class
	#region Popplio
	public class Popplio : PokemonInstance
	{
		#region Popplio Constructors
		/// <summary>
		/// Popplio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Popplio(string nickname, int level)
		: base(
				PopplioSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Popplio Constructor only waiting for a Level
		/// </summary>
		public Popplio(int level)
		: this( "Popplio", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Popplio Constructor waiting for no params
		/// </summary>
		/*
		public Popplio() : this( "Popplio", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}