using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Relicanth PokemonInstance Class
	#region Relicanth
	public class Relicanth : PokemonInstance
	{
		#region Relicanth Constructors
		/// <summary>
		/// Relicanth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Relicanth(string nickname, int level)
		: base(
				RelicanthSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Relicanth Constructor only waiting for a Level
		/// </summary>
		public Relicanth(int level)
		: this( "Relicanth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Relicanth Constructor waiting for no params
		/// </summary>
		/*
		public Relicanth() : this( "Relicanth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}