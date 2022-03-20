using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Oshawott PokemonInstance Class
	#region Oshawott
	public class Oshawott : PokemonInstance
	{
		#region Oshawott Constructors
		/// <summary>
		/// Oshawott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Oshawott(string nickname, int level)
		: base(
				OshawottSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oshawott Constructor only waiting for a Level
		/// </summary>
		public Oshawott(int level)
		: this( "Oshawott", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oshawott Constructor waiting for no params
		/// </summary>
		/*
		public Oshawott() : this( "Oshawott", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}