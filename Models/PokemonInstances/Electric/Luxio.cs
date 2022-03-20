using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Luxio PokemonInstance Class
	#region Luxio
	public class Luxio : PokemonInstance
	{
		#region Luxio Constructors
		/// <summary>
		/// Luxio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Luxio(string nickname, int level)
		: base(
				LuxioSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxio Constructor only waiting for a Level
		/// </summary>
		public Luxio(int level)
		: this( "Luxio", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxio Constructor waiting for no params
		/// </summary>
		/*
		public Luxio() : this( "Luxio", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}