using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sealeo PokemonInstance Class
	#region Sealeo
	public class Sealeo : PokemonInstance
	{
		#region Sealeo Constructors
		/// <summary>
		/// Sealeo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sealeo(string nickname, int level)
		: base(
				SealeoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sealeo Constructor only waiting for a Level
		/// </summary>
		public Sealeo(int level)
		: this( "Sealeo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sealeo Constructor waiting for no params
		/// </summary>
		/*
		public Sealeo() : this( "Sealeo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}