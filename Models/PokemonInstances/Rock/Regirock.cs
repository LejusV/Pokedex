using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Regirock PokemonInstance Class
	#region Regirock
	public class Regirock : PokemonInstance
	{
		#region Regirock Constructors
		/// <summary>
		/// Regirock Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Regirock(string nickname, int level)
		: base(
				RegirockSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regirock Constructor only waiting for a Level
		/// </summary>
		public Regirock(int level)
		: this( "Regirock", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regirock Constructor waiting for no params
		/// </summary>
		/*
		public Regirock() : this( "Regirock", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}