using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Umbreon PokemonInstance Class
	#region Umbreon
	public class Umbreon : PokemonInstance
	{
		#region Umbreon Constructors
		/// <summary>
		/// Umbreon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Umbreon(string nickname, int level)
		: base(
				UmbreonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Umbreon Constructor only waiting for a Level
		/// </summary>
		public Umbreon(int level)
		: this( "Umbreon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Umbreon Constructor waiting for no params
		/// </summary>
		/*
		public Umbreon() : this( "Umbreon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}