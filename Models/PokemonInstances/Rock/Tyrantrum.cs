using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tyrantrum PokemonInstance Class
	#region Tyrantrum
	public class Tyrantrum : PokemonInstance
	{
		#region Tyrantrum Constructors
		/// <summary>
		/// Tyrantrum Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tyrantrum(string nickname, int level)
		: base(
				TyrantrumSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrantrum Constructor only waiting for a Level
		/// </summary>
		public Tyrantrum(int level)
		: this( "Tyrantrum", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrantrum Constructor waiting for no params
		/// </summary>
		/*
		public Tyrantrum() : this( "Tyrantrum", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}