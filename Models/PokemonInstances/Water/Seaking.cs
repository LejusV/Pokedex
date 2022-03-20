using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Seaking PokemonInstance Class
	#region Seaking
	public class Seaking : PokemonInstance
	{
		#region Seaking Constructors
		/// <summary>
		/// Seaking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Seaking(string nickname, int level)
		: base(
				SeakingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seaking Constructor only waiting for a Level
		/// </summary>
		public Seaking(int level)
		: this( "Seaking", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seaking Constructor waiting for no params
		/// </summary>
		/*
		public Seaking() : this( "Seaking", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}