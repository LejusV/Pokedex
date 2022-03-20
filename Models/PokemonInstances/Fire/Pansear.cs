using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pansear PokemonInstance Class
	#region Pansear
	public class Pansear : PokemonInstance
	{
		#region Pansear Constructors
		/// <summary>
		/// Pansear Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pansear(string nickname, int level)
		: base(
				PansearSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansear Constructor only waiting for a Level
		/// </summary>
		public Pansear(int level)
		: this( "Pansear", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansear Constructor waiting for no params
		/// </summary>
		/*
		public Pansear() : this( "Pansear", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}