using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Obstagoon PokemonInstance Class
	#region Obstagoon
	public class Obstagoon : PokemonInstance
	{
		#region Obstagoon Constructors
		/// <summary>
		/// Obstagoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Obstagoon(string nickname, int level)
		: base(
				ObstagoonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Obstagoon Constructor only waiting for a Level
		/// </summary>
		public Obstagoon(int level)
		: this( "Obstagoon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Obstagoon Constructor waiting for no params
		/// </summary>
		/*
		public Obstagoon() : this( "Obstagoon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}