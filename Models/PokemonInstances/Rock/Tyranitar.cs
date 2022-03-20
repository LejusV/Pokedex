using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tyranitar PokemonInstance Class
	#region Tyranitar
	public class Tyranitar : PokemonInstance
	{
		#region Tyranitar Constructors
		/// <summary>
		/// Tyranitar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tyranitar(string nickname, int level)
		: base(
				TyranitarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyranitar Constructor only waiting for a Level
		/// </summary>
		public Tyranitar(int level)
		: this( "Tyranitar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyranitar Constructor waiting for no params
		/// </summary>
		/*
		public Tyranitar() : this( "Tyranitar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}