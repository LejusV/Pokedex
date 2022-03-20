using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Type-Null PokemonInstance Class
	#region Type-Null
	public class TypeNull : PokemonInstance
	{
		#region Type-Null Constructors
		/// <summary>
		/// Type-Null Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TypeNull(string nickname, int level)
		: base(
				TypeNullSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Type-Null Constructor only waiting for a Level
		/// </summary>
		public TypeNull(int level)
		: this( "Type-Null", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Type-Null Constructor waiting for no params
		/// </summary>
		/*
		public TypeNull() : this( "Type-Null", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}