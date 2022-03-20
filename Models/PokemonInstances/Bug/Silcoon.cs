using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Silcoon PokemonInstance Class
	#region Silcoon
	public class Silcoon : PokemonInstance
	{
		#region Silcoon Constructors
		/// <summary>
		/// Silcoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Silcoon(string nickname, int level)
		: base(
				SilcoonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silcoon Constructor only waiting for a Level
		/// </summary>
		public Silcoon(int level)
		: this( "Silcoon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silcoon Constructor waiting for no params
		/// </summary>
		/*
		public Silcoon() : this( "Silcoon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}