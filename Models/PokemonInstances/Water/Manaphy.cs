using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Manaphy PokemonInstance Class
	#region Manaphy
	public class Manaphy : PokemonInstance
	{
		#region Manaphy Constructors
		/// <summary>
		/// Manaphy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Manaphy(string nickname, int level)
		: base(
				ManaphySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manaphy Constructor only waiting for a Level
		/// </summary>
		public Manaphy(int level)
		: this( "Manaphy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manaphy Constructor waiting for no params
		/// </summary>
		/*
		public Manaphy() : this( "Manaphy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}