using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hitmonlee PokemonInstance Class
	#region Hitmonlee
	public class Hitmonlee : PokemonInstance
	{
		#region Hitmonlee Constructors
		/// <summary>
		/// Hitmonlee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hitmonlee(string nickname, int level)
		: base(
				HitmonleeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonlee Constructor only waiting for a Level
		/// </summary>
		public Hitmonlee(int level)
		: this( "Hitmonlee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonlee Constructor waiting for no params
		/// </summary>
		/*
		public Hitmonlee() : this( "Hitmonlee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}