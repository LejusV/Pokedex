using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hatenna PokemonInstance Class
	#region Hatenna
	public class Hatenna : PokemonInstance
	{
		#region Hatenna Constructors
		/// <summary>
		/// Hatenna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hatenna(string nickname, int level)
		: base(
				HatennaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatenna Constructor only waiting for a Level
		/// </summary>
		public Hatenna(int level)
		: this( "Hatenna", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatenna Constructor waiting for no params
		/// </summary>
		/*
		public Hatenna() : this( "Hatenna", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}