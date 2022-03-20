using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Solosis PokemonInstance Class
	#region Solosis
	public class Solosis : PokemonInstance
	{
		#region Solosis Constructors
		/// <summary>
		/// Solosis Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Solosis(string nickname, int level)
		: base(
				SolosisSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solosis Constructor only waiting for a Level
		/// </summary>
		public Solosis(int level)
		: this( "Solosis", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solosis Constructor waiting for no params
		/// </summary>
		/*
		public Solosis() : this( "Solosis", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}