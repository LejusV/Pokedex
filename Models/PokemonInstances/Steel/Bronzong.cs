using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bronzong PokemonInstance Class
	#region Bronzong
	public class Bronzong : PokemonInstance
	{
		#region Bronzong Constructors
		/// <summary>
		/// Bronzong Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bronzong(string nickname, int level)
		: base(
				BronzongSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzong Constructor only waiting for a Level
		/// </summary>
		public Bronzong(int level)
		: this( "Bronzong", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzong Constructor waiting for no params
		/// </summary>
		/*
		public Bronzong() : this( "Bronzong", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}