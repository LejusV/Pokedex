using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Staraptor PokemonInstance Class
	#region Staraptor
	public class Staraptor : PokemonInstance
	{
		#region Staraptor Constructors
		/// <summary>
		/// Staraptor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Staraptor(string nickname, int level)
		: base(
				StaraptorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staraptor Constructor only waiting for a Level
		/// </summary>
		public Staraptor(int level)
		: this( "Staraptor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staraptor Constructor waiting for no params
		/// </summary>
		/*
		public Staraptor() : this( "Staraptor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}