using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grapploct PokemonInstance Class
	#region Grapploct
	public class Grapploct : PokemonInstance
	{
		#region Grapploct Constructors
		/// <summary>
		/// Grapploct Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grapploct(string nickname, int level)
		: base(
				GrapploctSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grapploct Constructor only waiting for a Level
		/// </summary>
		public Grapploct(int level)
		: this( "Grapploct", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grapploct Constructor waiting for no params
		/// </summary>
		/*
		public Grapploct() : this( "Grapploct", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}