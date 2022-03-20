using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Regigigas PokemonInstance Class
	#region Regigigas
	public class Regigigas : PokemonInstance
	{
		#region Regigigas Constructors
		/// <summary>
		/// Regigigas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Regigigas(string nickname, int level)
		: base(
				RegigigasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regigigas Constructor only waiting for a Level
		/// </summary>
		public Regigigas(int level)
		: this( "Regigigas", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regigigas Constructor waiting for no params
		/// </summary>
		/*
		public Regigigas() : this( "Regigigas", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}