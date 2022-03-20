using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Doduo PokemonInstance Class
	#region Doduo
	public class Doduo : PokemonInstance
	{
		#region Doduo Constructors
		/// <summary>
		/// Doduo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Doduo(string nickname, int level)
		: base(
				DoduoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doduo Constructor only waiting for a Level
		/// </summary>
		public Doduo(int level)
		: this( "Doduo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doduo Constructor waiting for no params
		/// </summary>
		/*
		public Doduo() : this( "Doduo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}