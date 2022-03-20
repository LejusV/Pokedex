using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ribombee PokemonInstance Class
	#region Ribombee
	public class Ribombee : PokemonInstance
	{
		#region Ribombee Constructors
		/// <summary>
		/// Ribombee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ribombee(string nickname, int level)
		: base(
				RibombeeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ribombee Constructor only waiting for a Level
		/// </summary>
		public Ribombee(int level)
		: this( "Ribombee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ribombee Constructor waiting for no params
		/// </summary>
		/*
		public Ribombee() : this( "Ribombee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}