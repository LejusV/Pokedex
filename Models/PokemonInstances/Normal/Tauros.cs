using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tauros PokemonInstance Class
	#region Tauros
	public class Tauros : PokemonInstance
	{
		#region Tauros Constructors
		/// <summary>
		/// Tauros Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tauros(string nickname, int level)
		: base(
				TaurosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tauros Constructor only waiting for a Level
		/// </summary>
		public Tauros(int level)
		: this( "Tauros", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tauros Constructor waiting for no params
		/// </summary>
		/*
		public Tauros() : this( "Tauros", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}