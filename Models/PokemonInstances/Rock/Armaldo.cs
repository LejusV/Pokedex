using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Armaldo PokemonInstance Class
	#region Armaldo
	public class Armaldo : PokemonInstance
	{
		#region Armaldo Constructors
		/// <summary>
		/// Armaldo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Armaldo(string nickname, int level)
		: base(
				ArmaldoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Armaldo Constructor only waiting for a Level
		/// </summary>
		public Armaldo(int level)
		: this( "Armaldo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Armaldo Constructor waiting for no params
		/// </summary>
		/*
		public Armaldo() : this( "Armaldo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}