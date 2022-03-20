using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Blastoise PokemonInstance Class
	#region Blastoise
	public class Blastoise : PokemonInstance
	{
		#region Blastoise Constructors
		/// <summary>
		/// Blastoise Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Blastoise(string nickname, int level)
		: base(
				BlastoiseSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blastoise Constructor only waiting for a Level
		/// </summary>
		public Blastoise(int level)
		: this( "Blastoise", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blastoise Constructor waiting for no params
		/// </summary>
		/*
		public Blastoise() : this( "Blastoise", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}