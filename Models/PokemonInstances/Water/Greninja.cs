using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Greninja PokemonInstance Class
	#region Greninja
	public class Greninja : PokemonInstance
	{
		#region Greninja Constructors
		/// <summary>
		/// Greninja Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Greninja(string nickname, int level)
		: base(
				GreninjaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greninja Constructor only waiting for a Level
		/// </summary>
		public Greninja(int level)
		: this( "Greninja", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greninja Constructor waiting for no params
		/// </summary>
		/*
		public Greninja() : this( "Greninja", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}