using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Entei PokemonInstance Class
	#region Entei
	public class Entei : PokemonInstance
	{
		#region Entei Constructors
		/// <summary>
		/// Entei Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Entei(string nickname, int level)
		: base(
				EnteiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Entei Constructor only waiting for a Level
		/// </summary>
		public Entei(int level)
		: this( "Entei", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Entei Constructor waiting for no params
		/// </summary>
		/*
		public Entei() : this( "Entei", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}