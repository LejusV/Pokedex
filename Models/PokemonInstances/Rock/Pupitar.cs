using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pupitar PokemonInstance Class
	#region Pupitar
	public class Pupitar : PokemonInstance
	{
		#region Pupitar Constructors
		/// <summary>
		/// Pupitar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pupitar(string nickname, int level)
		: base(
				PupitarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pupitar Constructor only waiting for a Level
		/// </summary>
		public Pupitar(int level)
		: this( "Pupitar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pupitar Constructor waiting for no params
		/// </summary>
		/*
		public Pupitar() : this( "Pupitar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}