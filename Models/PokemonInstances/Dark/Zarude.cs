using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zarude PokemonInstance Class
	#region Zarude
	public class Zarude : PokemonInstance
	{
		#region Zarude Constructors
		/// <summary>
		/// Zarude Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zarude(string nickname, int level)
		: base(
				ZarudeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zarude Constructor only waiting for a Level
		/// </summary>
		public Zarude(int level)
		: this( "Zarude", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zarude Constructor waiting for no params
		/// </summary>
		/*
		public Zarude() : this( "Zarude", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}