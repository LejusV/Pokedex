using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Arrokuda PokemonInstance Class
	#region Arrokuda
	public class Arrokuda : PokemonInstance
	{
		#region Arrokuda Constructors
		/// <summary>
		/// Arrokuda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Arrokuda(string nickname, int level)
		: base(
				ArrokudaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arrokuda Constructor only waiting for a Level
		/// </summary>
		public Arrokuda(int level)
		: this( "Arrokuda", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arrokuda Constructor waiting for no params
		/// </summary>
		/*
		public Arrokuda() : this( "Arrokuda", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}