using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ambipom PokemonInstance Class
	#region Ambipom
	public class Ambipom : PokemonInstance
	{
		#region Ambipom Constructors
		/// <summary>
		/// Ambipom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ambipom(string nickname, int level)
		: base(
				AmbipomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ambipom Constructor only waiting for a Level
		/// </summary>
		public Ambipom(int level)
		: this( "Ambipom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ambipom Constructor waiting for no params
		/// </summary>
		/*
		public Ambipom() : this( "Ambipom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}