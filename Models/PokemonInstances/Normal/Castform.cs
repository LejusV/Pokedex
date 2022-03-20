using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Castform PokemonInstance Class
	#region Castform
	public class Castform : PokemonInstance
	{
		#region Castform Constructors
		/// <summary>
		/// Castform Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Castform(string nickname, int level)
		: base(
				CastformSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Castform Constructor only waiting for a Level
		/// </summary>
		public Castform(int level)
		: this( "Castform", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Castform Constructor waiting for no params
		/// </summary>
		/*
		public Castform() : this( "Castform", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}