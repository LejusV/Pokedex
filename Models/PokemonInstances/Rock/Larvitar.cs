using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Larvitar PokemonInstance Class
	#region Larvitar
	public class Larvitar : PokemonInstance
	{
		#region Larvitar Constructors
		/// <summary>
		/// Larvitar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Larvitar(string nickname, int level)
		: base(
				LarvitarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvitar Constructor only waiting for a Level
		/// </summary>
		public Larvitar(int level)
		: this( "Larvitar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvitar Constructor waiting for no params
		/// </summary>
		/*
		public Larvitar() : this( "Larvitar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}