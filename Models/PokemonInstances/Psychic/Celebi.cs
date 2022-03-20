using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Celebi PokemonInstance Class
	#region Celebi
	public class Celebi : PokemonInstance
	{
		#region Celebi Constructors
		/// <summary>
		/// Celebi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Celebi(string nickname, int level)
		: base(
				CelebiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celebi Constructor only waiting for a Level
		/// </summary>
		public Celebi(int level)
		: this( "Celebi", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celebi Constructor waiting for no params
		/// </summary>
		/*
		public Celebi() : this( "Celebi", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}