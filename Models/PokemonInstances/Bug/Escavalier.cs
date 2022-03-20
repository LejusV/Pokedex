using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Escavalier PokemonInstance Class
	#region Escavalier
	public class Escavalier : PokemonInstance
	{
		#region Escavalier Constructors
		/// <summary>
		/// Escavalier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Escavalier(string nickname, int level)
		: base(
				EscavalierSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Escavalier Constructor only waiting for a Level
		/// </summary>
		public Escavalier(int level)
		: this( "Escavalier", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Escavalier Constructor waiting for no params
		/// </summary>
		/*
		public Escavalier() : this( "Escavalier", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}