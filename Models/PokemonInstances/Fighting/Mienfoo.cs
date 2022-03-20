using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mienfoo PokemonInstance Class
	#region Mienfoo
	public class Mienfoo : PokemonInstance
	{
		#region Mienfoo Constructors
		/// <summary>
		/// Mienfoo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mienfoo(string nickname, int level)
		: base(
				MienfooSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienfoo Constructor only waiting for a Level
		/// </summary>
		public Mienfoo(int level)
		: this( "Mienfoo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienfoo Constructor waiting for no params
		/// </summary>
		/*
		public Mienfoo() : this( "Mienfoo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}