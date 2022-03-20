using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Abomasnow PokemonInstance Class
	#region Abomasnow
	public class Abomasnow : PokemonInstance
	{
		#region Abomasnow Constructors
		/// <summary>
		/// Abomasnow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Abomasnow(string nickname, int level)
		: base(
				AbomasnowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abomasnow Constructor only waiting for a Level
		/// </summary>
		public Abomasnow(int level)
		: this( "Abomasnow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abomasnow Constructor waiting for no params
		/// </summary>
		/*
		public Abomasnow() : this( "Abomasnow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}