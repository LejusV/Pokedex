using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cloyster PokemonInstance Class
	#region Cloyster
	public class Cloyster : PokemonInstance
	{
		#region Cloyster Constructors
		/// <summary>
		/// Cloyster Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cloyster(string nickname, int level)
		: base(
				CloysterSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cloyster Constructor only waiting for a Level
		/// </summary>
		public Cloyster(int level)
		: this( "Cloyster", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cloyster Constructor waiting for no params
		/// </summary>
		/*
		public Cloyster() : this( "Cloyster", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}