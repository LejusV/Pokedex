using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zeraora PokemonInstance Class
	#region Zeraora
	public class Zeraora : PokemonInstance
	{
		#region Zeraora Constructors
		/// <summary>
		/// Zeraora Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zeraora(string nickname, int level)
		: base(
				ZeraoraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zeraora Constructor only waiting for a Level
		/// </summary>
		public Zeraora(int level)
		: this( "Zeraora", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zeraora Constructor waiting for no params
		/// </summary>
		/*
		public Zeraora() : this( "Zeraora", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}