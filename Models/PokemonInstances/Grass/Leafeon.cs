using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Leafeon PokemonInstance Class
	#region Leafeon
	public class Leafeon : PokemonInstance
	{
		#region Leafeon Constructors
		/// <summary>
		/// Leafeon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Leafeon(string nickname, int level)
		: base(
				LeafeonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leafeon Constructor only waiting for a Level
		/// </summary>
		public Leafeon(int level)
		: this( "Leafeon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leafeon Constructor waiting for no params
		/// </summary>
		/*
		public Leafeon() : this( "Leafeon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}