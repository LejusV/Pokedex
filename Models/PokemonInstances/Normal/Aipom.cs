using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aipom PokemonInstance Class
	#region Aipom
	public class Aipom : PokemonInstance
	{
		#region Aipom Constructors
		/// <summary>
		/// Aipom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Aipom(string nickname, int level)
		: base(
				AipomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aipom Constructor only waiting for a Level
		/// </summary>
		public Aipom(int level)
		: this( "Aipom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aipom Constructor waiting for no params
		/// </summary>
		/*
		public Aipom() : this( "Aipom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}