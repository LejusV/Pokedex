using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bayleef PokemonInstance Class
	#region Bayleef
	public class Bayleef : PokemonInstance
	{
		#region Bayleef Constructors
		/// <summary>
		/// Bayleef Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bayleef(string nickname, int level)
		: base(
				BayleefSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bayleef Constructor only waiting for a Level
		/// </summary>
		public Bayleef(int level)
		: this( "Bayleef", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bayleef Constructor waiting for no params
		/// </summary>
		/*
		public Bayleef() : this( "Bayleef", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}