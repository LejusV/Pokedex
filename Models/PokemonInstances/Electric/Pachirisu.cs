using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pachirisu PokemonInstance Class
	#region Pachirisu
	public class Pachirisu : PokemonInstance
	{
		#region Pachirisu Constructors
		/// <summary>
		/// Pachirisu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pachirisu(string nickname, int level)
		: base(
				PachirisuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pachirisu Constructor only waiting for a Level
		/// </summary>
		public Pachirisu(int level)
		: this( "Pachirisu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pachirisu Constructor waiting for no params
		/// </summary>
		/*
		public Pachirisu() : this( "Pachirisu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}