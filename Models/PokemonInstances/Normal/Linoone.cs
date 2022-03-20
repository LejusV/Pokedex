using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Linoone PokemonInstance Class
	#region Linoone
	public class Linoone : PokemonInstance
	{
		#region Linoone Constructors
		/// <summary>
		/// Linoone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Linoone(string nickname, int level)
		: base(
				LinooneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Linoone Constructor only waiting for a Level
		/// </summary>
		public Linoone(int level)
		: this( "Linoone", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Linoone Constructor waiting for no params
		/// </summary>
		/*
		public Linoone() : this( "Linoone", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}