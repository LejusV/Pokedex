using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jynx PokemonInstance Class
	#region Jynx
	public class Jynx : PokemonInstance
	{
		#region Jynx Constructors
		/// <summary>
		/// Jynx Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Jynx(string nickname, int level)
		: base(
				JynxSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jynx Constructor only waiting for a Level
		/// </summary>
		public Jynx(int level)
		: this( "Jynx", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jynx Constructor waiting for no params
		/// </summary>
		/*
		public Jynx() : this( "Jynx", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}