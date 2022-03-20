using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Politoed PokemonInstance Class
	#region Politoed
	public class Politoed : PokemonInstance
	{
		#region Politoed Constructors
		/// <summary>
		/// Politoed Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Politoed(string nickname, int level)
		: base(
				PolitoedSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Politoed Constructor only waiting for a Level
		/// </summary>
		public Politoed(int level)
		: this( "Politoed", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Politoed Constructor waiting for no params
		/// </summary>
		/*
		public Politoed() : this( "Politoed", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}