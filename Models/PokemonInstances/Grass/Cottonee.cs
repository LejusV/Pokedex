using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cottonee PokemonInstance Class
	#region Cottonee
	public class Cottonee : PokemonInstance
	{
		#region Cottonee Constructors
		/// <summary>
		/// Cottonee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cottonee(string nickname, int level)
		: base(
				CottoneeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cottonee Constructor only waiting for a Level
		/// </summary>
		public Cottonee(int level)
		: this( "Cottonee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cottonee Constructor waiting for no params
		/// </summary>
		/*
		public Cottonee() : this( "Cottonee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}