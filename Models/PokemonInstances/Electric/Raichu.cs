using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Raichu PokemonInstance Class
	#region Raichu
	public class Raichu : PokemonInstance
	{
		#region Raichu Constructors
		/// <summary>
		/// Raichu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Raichu(string nickname, int level)
		: base(
				RaichuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raichu Constructor only waiting for a Level
		/// </summary>
		public Raichu(int level)
		: this( "Raichu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raichu Constructor waiting for no params
		/// </summary>
		/*
		public Raichu() : this( "Raichu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}