using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Amoonguss PokemonInstance Class
	#region Amoonguss
	public class Amoonguss : PokemonInstance
	{
		#region Amoonguss Constructors
		/// <summary>
		/// Amoonguss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Amoonguss(string nickname, int level)
		: base(
				AmoongussSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amoonguss Constructor only waiting for a Level
		/// </summary>
		public Amoonguss(int level)
		: this( "Amoonguss", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amoonguss Constructor waiting for no params
		/// </summary>
		/*
		public Amoonguss() : this( "Amoonguss", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}