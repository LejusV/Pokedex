using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Combee PokemonInstance Class
	#region Combee
	public class Combee : PokemonInstance
	{
		#region Combee Constructors
		/// <summary>
		/// Combee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Combee(string nickname, int level)
		: base(
				CombeeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combee Constructor only waiting for a Level
		/// </summary>
		public Combee(int level)
		: this( "Combee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combee Constructor waiting for no params
		/// </summary>
		/*
		public Combee() : this( "Combee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}